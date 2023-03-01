using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Company
    {
        static void Main(string[] args)
        {
            company company1;
            company1 = new company("Микрософт", 5000, 3000000);
            company1.name = "Computers";
            company1.persons = 10;
            company1.money = 300000;
            Console.WriteLine(company1.name);
            Console.WriteLine(company1.persons);
            Console.WriteLine(company1.money);
            company factory = new company("Премьер", 100, 1000000);
            factory.show();
            Console.WriteLine("Средняя зарплата: " + factory.averageSalary());
            Console.WriteLine("Отчисления: " + factory.minus(13, 4));
            Console.WriteLine("Средняя зарплата?");
            int average = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество сотрудников: " + factory.maxPersons(average));
        }
    }
}
  
