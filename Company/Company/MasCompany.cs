using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class MasCompany
    {
        public static void Mas()
        {
            int i;
            company[] CityCompany = new company[5];
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Информация о компании: \n");
                CityCompany[i] = new company(
                    Console.ReadLine(),
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
            }
            for (i = 0; i < 5; i++)
                if (CityCompany[i].averageSalary() > 10000)
                    CityCompany[i].show();
        }
    }
}
