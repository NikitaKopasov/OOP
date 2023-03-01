using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class company
    {
        public string name; //название
        public int persons; //количество сотрудников
        public int money; // месячный фонд заработной платы
        public company(string _name, int _persons, int _money)
        {
            this.name = _name;
            this.persons = _persons;
            this.money = _money;
        }
        public void show()
        {
            Console.WriteLine("В компании " + name +" трудятся " + persons + " сотрудников ");
            Console.WriteLine("Фонд зарплаты: " + money);
        }
        public int averageSalary()
        {
            return money / persons;
        }
        public int maxPersons(int salary)
        {
            return money / salary;
        }
        public int minus(int minus1/*налог в %*/,int minus2 /*отчисление в ПФ в %*/)
        {
            return money * (minus1 + minus2) / 100;
        }
    };
}
