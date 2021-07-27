using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            personel.Name = "M.Enes";
            personel.LastName = "Karaca";
            personel.Age = 400;
            personel.Fee = 3000;

            personel.WriteValues();

            personel.RaiseFee(500);
            personel.Age = 40;

            personel.WriteValues();
        }
    }
}
