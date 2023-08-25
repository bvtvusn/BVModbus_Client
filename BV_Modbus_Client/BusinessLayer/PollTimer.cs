using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV_Modbus_Client.BusinessLayer
{
    internal class PollTimer
    {
        List<FcWrapperBase> FcPollOrder;
        System.Timers.Timer timer_pollTimer;
        public event Action<(string, string)[],bool> PollFinishedEvent;
        bool changedFlag;
        public PollTimer(double interval)
        {
            FcPollOrder = new List<FcWrapperBase>();
            timer_pollTimer = new System.Timers.Timer(interval * 1000);
            timer_pollTimer.Enabled = true;
            timer_pollTimer.AutoReset = true;
            
            timer_pollTimer.Elapsed += Timer_pollTimer_Elapsed;
        }
        

        public bool TimerEnabled
        {
            
            set { timer_pollTimer.Enabled = value; }
        }

        private void Timer_pollTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            PollAll();
        }

        internal void UpdatePollList(FcWrapperBase fc, bool pollingEnabled)
        {
            if (pollingEnabled)
            {
                if (!FcPollOrder.Contains(fc))
                {
                    FcPollOrder.Add(fc);
                }

            }
            else
            {
                FcPollOrder.RemoveAll(s => Object.ReferenceEquals(s,fc));
            }
            changedFlag = true;
        }
        public bool CheckPollingEnabled(FcWrapperBase obj)
        {
            return FcPollOrder.Contains(obj);
        }
        internal async void PollAll()
        {
            await Task.WhenAll(FcPollOrder.Select(x => x.ExecuteReadAsync()));

            List<(string,string)> strdata = new List<(string,string)>();
            foreach (FcWrapperBase item in FcPollOrder)
            {
                // REad out the data
                (string, string)[] data = item.GetDataAsString(true);
               
                //string[] viewData = data.Select(x => x.Item1).ToArray();
               strdata.AddRange(data);
                //await item.ExecuteReadAsync();
                //item.DataBuffer
            }
            PollFinishedEvent?.Invoke(strdata.ToArray(), changedFlag);
            changedFlag = false;
        }

        internal void SetInterval(double timer_PollInterval)
        {
            timer_pollTimer.Interval = timer_PollInterval * 1000;
        }

        internal void EnumerateCommands()
        {
            for (int i = 0; i < FcPollOrder.Count; i++)
            {
                FcPollOrder[i].SavedPollOrder = i;
            }            
        }
    }
}
