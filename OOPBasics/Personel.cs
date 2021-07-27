using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Personel
    {
        public Personel()
        {
            Name = "xxx";
            LastName = "xxx";
            Age = 0;
            Fee = 0;
        }

        ~Personel()
        {
            Console.WriteLine("Burası Yıkıcı Metod");
        }

        public string Name;
        public string LastName;
        public int Age
        {
            get { return _Age; }
            set
            {
                if (value < 0 || value > 100)
                    value = 0;
                _Age = value;
            }
        }
        private int _Age;
        public int Fee;

        public void WriteValues()
        {
            Console.WriteLine(Name);
            Console.WriteLine(LastName);
            Console.WriteLine(Age);
            Console.WriteLine(Fee);
        }

        public int RaiseFee(int raiseQuantity)
        {
            Fee = Fee + raiseQuantity;
            return Fee;
        }
    }
}
