using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Tests
{
    class GsmTest
    {
        private Random rng = new Random();
        private string GenPhoneManufacturer()
        {
            string[] name = { "Alcatel", "Motorolla", "Samsung", "Siemens", "Pravetz",
                "Huawei", "Gergifon", "Iphone", "Lenovo", "Nokia", "Nintendo" };
            return name[this.rng.Next(0, 9)];
        }
        private string GenPhoneModel()
        {
            string[] model = { "A-60", "g30", "y7", "t100", "3110",
                "galaxy", "1", "model-a", "custom-built", "88" };
            return model[this.rng.Next(0, 9)];
        }
        private double GenPhonePrice()
        {
            int price = this.rng.Next(1, 1000);
            double priceMulty = this.rng.NextDouble();
            return Math.Round((price * priceMulty), 2);
        }
        private string GenPhoneOwner()
        {
            string[] firstName = { "Alex", "John", "Artyom", "Samantha", "Sophia",
                "George", "Isaac", "Radju", "Freddie", "Conan", "Ilarion" };
            string[] lastName = { "Kafka", "Adams", "Verne", "Lovecraft", "Strugatsky",
                "Wells", "Herbert", "Heinlein", "Clarke", "Pratchett" };
            string name = firstName[this.rng.Next(0, 9)] + " " + lastName[this.rng.Next(0, 9)];
            return name;
        }
        private string GenBatteryModel()
        {
            string[] model = { "g5", "h7", "mg-90", "111", "69",
                "s85", "hjk99", "11210", "varta-AA", "Car Battery-120A" };
            return model[this.rng.Next(0, 9)];
        }
        private double GenBatteryIdleTime()
        {
            int time = this.rng.Next(100, 200);
            double timeMulty = this.rng.NextDouble();
            return time * timeMulty+100;
        }
        private double GenBatteryHoursTalk()
        {
            int time = this.rng.Next(50, 100);
            double timeMulty = this.rng.NextDouble();
            return Math.Abs(time * timeMulty - this.rng.Next(49, 100));
        }
        private double GenScreenSize()
        {
            int wholeNum = this.rng.Next(4, 7);
            double decimalNum = this.rng.NextDouble();
            return Math.Round((wholeNum + decimalNum), 2);
        }
        private ulong GenScreenColors()
        {
            int seedValue = this.rng.Next(5, 15);
            ulong screenSize = (ulong)(seedValue * 1000000);
            return screenSize;
        }
        private void FillPhoneInfo(MobilePhone phone)
        {
            phone.Model = GenPhoneModel();
            phone.Manufacturer = GenPhoneManufacturer();
            phone.Price = GenPhonePrice();
            phone.Owner = GenPhoneOwner();
            phone.Battery.Model = GenBatteryModel();
            phone.Battery.IdleTime = GenBatteryIdleTime();
            phone.Battery.HoursTalk = GenBatteryHoursTalk();
            phone.Screen.ScreenSize = GenScreenSize();
            phone.Screen.ScreenColors = GenScreenColors();
        }
        private MobilePhone[] GenPhones()
        {
            MobilePhone[] phone = new MobilePhone[this.rng.Next(1, 11)];
            for (int i = 0; i < phone.Length; i++)
            {
                phone[i] = new MobilePhone();
                FillPhoneInfo(phone[i]);
            }
            return phone;
        }
        public void Test()
        {
            MobilePhone[] phones = GenPhones();
            Console.WriteLine(new string('*', 80));
            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine($"{phones[i]} \r\n ");
                Console.WriteLine(new string('*', 80));
            }
        }
        public MobilePhone GenSinglePhone()
        {
            MobilePhone phone = new MobilePhone();
            FillPhoneInfo(phone);
            return phone;
        }
        public void TestStatic()
        {
            Console.WriteLine("*Static Phone:*");
            MobilePhone.PrintNokiaN95Info();
        }
    }
}
