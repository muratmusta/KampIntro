using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoggerServices : ILoggerService
    {
   
        public void Log()
        {
            Console.WriteLine("Sms yollandı");
        }
    }
}
