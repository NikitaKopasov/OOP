using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClassCompany
{
    internal class mashin1
    {
        static void Main(string[] args)
        {
            Car mashina = new Car();
            {
                mashina.Mark = "Lada";
                mashina.Model = "Granta";
                mashina.Number = "Bu3iL";
                mashina.start();
                mashina.stop();
            }
            Car mashina2 = new Car();
            {
                mashina2.Mark = "Ferrari";
                mashina2.Model = "F40";
                mashina2.Number = "C4n64";
                mashina2.start();
                mashina2.stop();
            }
            Console.ReadKey();
        }
    }
}