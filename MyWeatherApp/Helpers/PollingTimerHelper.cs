using System;
using System.Threading;
using Xamarin.Forms;

namespace MyWeatherApp.Helpers
{
    public class PollingTimerHelper
    {
        private readonly TimeSpan timespan;
        private readonly Action callback;

        private CancellationTokenSource cancellationTokenSource;


        /// <param name="timespan">The amount of time between each call</param>
        /// <param name="callback">The callback procedure.</param>
        public PollingTimerHelper(TimeSpan timespan, Action callback)
        {
            this.timespan = timespan;
            this.callback = callback;
            this.cancellationTokenSource = new CancellationTokenSource();
        }

        /// <summary>
        /// Starts the timer.
        /// </summary>
        public void Start()
        {
            CancellationTokenSource cts = this.cancellationTokenSource; // safe copy
            Device.StartTimer(this.timespan,
                () =>
                {
                    if (cts.IsCancellationRequested) return false;
                    this.callback.Invoke();
                    return true; // or true for periodic behavior
                });
        }

        /// <summary>
        /// Stops the timer.
        /// </summary>
        public void Stop()
        {
            Interlocked.Exchange(ref this.cancellationTokenSource, new CancellationTokenSource()).Cancel();
        }
    }
}
