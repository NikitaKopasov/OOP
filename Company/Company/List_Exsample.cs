using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class List_Exsample
    {
        public static void List()
        {
            List<company> comp1 = new List<company>()
            {
                new company("ABCD1", 101, 900001),
                new company("ABCD2", 102, 900002),
                new company("ABCD3", 103, 900003)
            };
        }
    }
}
