using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Classes.Tests
{
    class GsmCallHistoryTest
    {
        private Random rng = new Random();
        private MobilePhone GenPhoneCalls()
        {
            GsmTest test = new GsmTest();
            MobilePhone phone = new MobilePhone();
            phone = test.GenSinglePhone();

            for (int i = 0; i < rng.Next(5, 11); i++)
            {
                phone.AddCall(phone);
                phone.CallHistory[i].CallDuration += rng.Next(35, 121);
            }

            return phone;
        }
        private void PrintCalls(MobilePhone phone)
        {
            foreach (Call call in phone.CallHistory)
            {
                Console.WriteLine(new string('*', 80));
                Console.WriteLine(call);
            }
            Console.WriteLine(new string('*', 80));
        }
        private decimal GetCallsPrise(MobilePhone phone)
        {
            //decimal costPerMinute = 0.37M;
            decimal costPerSecond = 0.00617M;
            decimal cost = phone.GetCallsPrise(costPerSecond);
            return cost;
        }
        private void RemoveLongestCall(MobilePhone phone)
        {
            decimal longestCall = 0M;
            int longestCallIndex = 0;
            for (int i = 0; i < phone.CallHistory.Count; i++)
            {
                var currentCall = phone.CallHistory[i].CallDuration;
                if (currentCall > longestCall)
                {
                    longestCall = currentCall;
                    longestCallIndex = i;
                }
            }
            Console.WriteLine($"Removed longest call: index[{longestCallIndex}], duration: {longestCall}.");
            phone.CallHistory.RemoveAt(longestCallIndex);
            phone.CallHistory.TrimExcess();
        }
        public void Initiate()
        {
            MobilePhone phone = GenPhoneCalls();
            PrintCalls(phone);
            decimal cost = GetCallsPrise(phone);
            Console.WriteLine("${0}$", cost);
            RemoveLongestCall(phone);
            cost = GetCallsPrise(phone);
            Console.WriteLine($"Cost without longest call: ${cost}$");
        }
    }
}
