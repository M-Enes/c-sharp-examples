using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoKiralama
{
    class Otomobil
    {
        public string Mark;
        public string Model;
        public int MotorCC;
        public float Length;
        public int RentPrice;
        public bool isRented = false;
        int TotalPrice;

        public int Rent(int Days)
        {
            RentedNot();
            TotalPrice += this.RentPrice * Days;
            Program.TotalRentPrice += this.RentPrice * Days;
            return this.RentPrice * Days;
        }

        void RentedNot()
        {
            this.isRented = !isRented;
        }

        public void Pay()
        {
            Program.Money -= TotalPrice;
            Program.TotalRentPrice -= TotalPrice;
            TotalPrice = 0;
            RentedNot();
        }
    }
}
