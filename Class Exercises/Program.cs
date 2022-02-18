using Classes.Tests;
using System;
using System.Threading;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass.TestIt();
            //var n = int.Parse(Console.ReadLine());
            //StudentTest test = new StudentTest(n);
            //test.Print();
            //StudentTest.GetStaticStudent();
            //StudentTest.StatStud.StudentInfo();
            //StudentTest.StatStud1.StudentInfo();
            //StudentTest.StatStud2.StudentInfo();
            //MobilePhone.PrintNokiaN95Info();
            //GsmTest test = new GsmTest();
            //test.Test();
            ////test.TestStatic();
            //MobilePhone phone = new GsmTest().GenSinglePhone();
            //Call newCall = new Call(phone);
            //newCall.StartCall();
            //Thread.Sleep(2100);
            //newCall.StopCall();
            //Console.WriteLine(newCall);
            //Console.WriteLine(newCall.CallDuration);
            GsmCallHistoryTest test = new GsmCallHistoryTest();
            test.Initiate();
        }
    }
}
