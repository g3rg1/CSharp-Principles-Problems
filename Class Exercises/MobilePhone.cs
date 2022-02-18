using System;
using System.Collections.Generic;
using System.Threading;

namespace Classes
{
    public class Battery
    {
        private string model = null;
        private double idleTime = 0;
        private double hoursTalk = 0;
        public Battery()
        {
        }
        public Battery(string model, int idleTime, double hoursTalk)
        {
            this.model = model;
            this.idleTime = idleTime;
            this.hoursTalk = hoursTalk;
        }
        public string Model
        {
            get => this.model;
            set => this.model = value;
        }
        public double IdleTime
        {
            get => this.idleTime;
            set => this.idleTime = value;
        }
        public double HoursTalk
        {
            get => this.hoursTalk;
            set => this.hoursTalk = value;
        }
    }
    public class Screen
    {
        private double screenSize = 0;
        private ulong screenColors = 0;
        public Screen()
        {
        }
        public Screen(int screenSize, ulong screenColors)
        {
            this.screenSize = screenSize;
            this.screenColors = screenColors;
        }
        public double ScreenSize
        {
            get => this.screenSize;
            set => this.screenSize = value;
        }
        public ulong ScreenColors
        {
            get => this.screenColors;
            set => this.screenColors = value;
        }
    }
    class MobilePhone
    {
        private string model = null;
        private string manufacturer = null;
        private double price = 0;
        private string owner = null;
        private Battery battery = new Battery();
        private Screen screen = new Screen();
        private static MobilePhone nokiaN95 = new MobilePhone();
        private List<Call> callHistory = new List<Call>();
        public MobilePhone()
        {

        }
        public MobilePhone(string model, string manufacturer, int price, string owner)
        {
            this.model = model ?? throw new ArgumentNullException(nameof(model));
            this.manufacturer = manufacturer ?? throw new ArgumentNullException(nameof(manufacturer));
            this.price = price;
            this.owner = owner ?? throw new ArgumentNullException(nameof(owner));
        }
        public string Model 
        {
            get => model;
            set => model = value;
        }
        public string Manufacturer
        {
            get => manufacturer;
            set => manufacturer = value;
        }
        public double Price
        {
            get => price;
            set => price = value;
        }
        public string Owner
        {
            get => owner;
            set => owner = value;
        }
        public Battery Battery
        {
            get => this.battery;
            set => this.battery = value;
        }
        public Screen Screen
        {
            get => this.screen;
            set => this.screen = value;
        }
        public List<Call> CallHistory
        {
            get => this.callHistory;
            set => this.CallHistory = value;
        }
        public static MobilePhone NokiaN95
        {
            get => MobilePhone.nokiaN95;
            set => MobilePhone.nokiaN95 = value;
        }
        private static void GetNokiaN95Spec()
        {
            nokiaN95.Model = "N95";
            nokiaN95.Manufacturer = "Nokia";
            nokiaN95.price = 100;
            nokiaN95.Owner = "Carl Zeiss";
            nokiaN95.Battery.Model = "BL-5F";
            nokiaN95.Battery.HoursTalk = 6.3;
            nokiaN95.Battery.IdleTime = 220;
            nokiaN95.Screen.ScreenSize = 2.6;
            nokiaN95.Screen.ScreenColors = 16000000;
        }
        public static void PrintNokiaN95Info()
        {
            GetNokiaN95Spec();
            Console.WriteLine("Manufacturer: {0}", NokiaN95.Manufacturer);
            Console.WriteLine("Model: {0}", NokiaN95.Model);
            Console.WriteLine("Owner: {0}", NokiaN95.Owner);
            Console.WriteLine("Price: {0}$", NokiaN95.Price);
            Console.WriteLine("Battery model: {0}", NokiaN95.Battery.Model);
            Console.WriteLine("Battery idle time: {0}h", NokiaN95.Battery.IdleTime);
            Console.WriteLine("Battery hours talk: {0}h", NokiaN95.Battery.HoursTalk);
            Console.WriteLine("Screen size: {0}\"", NokiaN95.Screen.ScreenSize);
            Console.WriteLine("Screen colors: {0}", NokiaN95.Screen.ScreenColors);
        }
        public override string ToString()
        {
            return $"Model: {Model} Manufacturer: {Manufacturer} Price: {Price}$ Owner: {Owner}\r\n" +
                $"Battery: {Battery.Model} Idle time: {Battery.IdleTime:f2}h HoursTalk: {Battery.HoursTalk:f2}h\r\n" +
                $"ScreenSize: {Screen.ScreenSize}\" ScreenColors: {Screen.ScreenColors}";
        }
        public void AddCall(MobilePhone phone)
        {
            var call = new Call(phone);
            call.StartCall();
            Thread.Sleep(100);
            call.StopCall();
            CallHistory.Add(call);
        }
        public void DeleteCall(int num)
        {
            CallHistory.RemoveAt(num);
            CallHistory.TrimExcess();
        }
        public void DeleteAllCalls()
        {
            CallHistory.Clear();
            CallHistory.TrimExcess();
        }
        public decimal GetCallsPrise(decimal costPerCall)
        {
            decimal totalCallDuration = 0M;
            foreach (Call call in CallHistory)
            {
                totalCallDuration += call.CallDuration;
            }
            decimal cost = totalCallDuration * costPerCall;
            return Math.Round(cost, 2);
        }
    }
}
