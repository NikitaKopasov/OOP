using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCompany
{
    public class Car
    {
        public string Mark;
        public string Number;
        public string Model;
        public void start()
        {
            Console.WriteLine($"Машина {Mark} {Model} завелась");
        }
        public void stop()
        {
            Console.WriteLine($"Машина {Mark} {Model} остановилась");
        }
    }
}