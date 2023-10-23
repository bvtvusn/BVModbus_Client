using System;
//using System.Threading;

namespace BV_Modbus_Client.BusinessLayer
{
    internal class EventBatcher
    {
        public event EventHandler BatchedEvent;
        private System.Timers.Timer timer;
        private bool unreportedEvent;
        private DateTime lastSourceEventTime;
        private int intervalMs;

        public object Data { get; internal set; }
        public void TriggerEvent(object data)
        {
            Data = data;
            TimeSpan tSinceLast = DateTime.Now - lastSourceEventTime;
            if (tSinceLast > TimeSpan.FromMilliseconds(intervalMs))
            {
                // Trigger immediately
                BatchedEvent?.Invoke(this, EventArgs.Empty);
                unreportedEvent = false;
            }
            else
            {
                // Trigger after timer
                unreportedEvent = true;
                timer.Start(); // Start or restart the timer when the source event is triggered
            }
            lastSourceEventTime = DateTime.Now;
        }

        public EventBatcher(int fastestIntervalMs)
        {
            intervalMs = fastestIntervalMs;
            timer = new System.Timers.Timer(fastestIntervalMs);
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = false;
            unreportedEvent = false;
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            // This event will be triggered approximately every 200ms if sourceEvent is continuously triggered
            if (unreportedEvent)
            {
                BatchedEvent?.Invoke(this, EventArgs.Empty);
                unreportedEvent = false;
            }
            timer.Stop(); // Stop the timer if the source event stops triggering
        }
    }
}
