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
        public event Action PollFinishedEvent;
        public PollTimer(double interval)
        {
            FcPollOrder = new List<FcWrapperBase>();
            timer_pollTimer = new System.Timers.Timer(interval * 1000);
            timer_pollTimer.Enabled = true;
            timer_pollTimer.AutoReset = true;
            
            timer_pollTimer.Elapsed += Timer_pollTimer_Elapsed;
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
        }
        public bool CheckPollingEnabled(FcWrapperBase obj)
        {
            return FcPollOrder.Contains(obj);
        }
        internal async void PollAll()
        {
            await Task.WhenAll(FcPollOrder.Select(x => x.ExecuteReadAsync()));

            foreach (FcWrapperBase item in FcPollOrder)
            {
                // REad out the data

                //await item.ExecuteReadAsync();
                //item.DataBuffer
            }
            PollFinishedEvent?.Invoke();
        }

        internal void SetInterval(double timer_PollInterval)
        {
            timer_pollTimer.Interval = timer_PollInterval * 1000;
        }
    }
}
