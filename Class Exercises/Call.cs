using Classes.Tests;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Classes
{
    class Call
    {
        private MobilePhone phone = null;
        private DateTime date = DateTime.MinValue;
        private Stopwatch elapsedTime = null;
        private decimal callDuration = 0M;
        public Call(MobilePhone phone)
        {
            this.phone = phone;
        }
        public MobilePhone Phone
        {
            get => this.phone;
            set => this.phone = value;
        }
        public Stopwatch ElapsedTime
        {
            get => this.elapsedTime;
            set => this.elapsedTime = value;
        }
        public decimal CallDuration
        {
            get => this.callDuration;
            set => this.callDuration = value;
        }
        public void StartCall()
        {
            this.date = DateTime.Now;
            this.elapsedTime = Stopwatch.StartNew();
        }
        public void StopCall()
        {
            this.elapsedTime.Stop();
            callDuration = Math.Round((decimal)elapsedTime.Elapsed.TotalSeconds, 2);
        }
        public override string ToString()
        {
            string call = $"Owner: {this.phone.Owner} " +
                $"Duration: {this.elapsedTime.Elapsed.Hours:f}h. " +
                $"{this.elapsedTime.Elapsed.Minutes:f}m. " +
                $"{this.elapsedTime.Elapsed.Seconds:f2}s. \r\n" +
                $"Date of Call: {this.date} \r\n" +
                $"Cost forming duration: {CallDuration}s";
            return call;
        }
    }
}
