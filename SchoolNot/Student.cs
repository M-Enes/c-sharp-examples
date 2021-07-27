using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNot
{
    public class Student
    {

        public Student(string name)
        {
            this.Name = name;
        }

        private int _CalculateCounter = 0;
        private int _AverageScore;
        private int _Average;
        private bool _Success;

        public int[] Score { get; set; }
        public string Name { get; set; }

        public bool Success
        {
            get { return _Success; }
        }
        public int Average
        {
            get { return _Average; }
        }
        public int AverageScore
        {
            get { return _AverageScore; }
        }
        public int CalculateCounter
        {
            get { return _CalculateCounter; }
        }

        public void Calculate()
        {
            int total = 0;

            for (int i = 0; i < Score.Length; i++)
            {
                total += Score[i];
            }
            _Average = total / Score.Length;

            if (Average >= 85)
                _AverageScore = 5;
            else if (Average >= 70)
                _AverageScore = 4;
            else if (Average >= 55)
                _AverageScore = 3;
            else if (Average >= 45)
                _AverageScore = 2;
            else
                _AverageScore = 1;


            _Success = _AverageScore > 1;
            _CalculateCounter++;
        }

        public string ShowResult()
        {
            if (Score != null && Score.Length > 0 && Average == 0)
            {
                Calculate();
            }

            if (Average > 0)
            {
                string StudentPass = Success ? "başarılı" : "başarısız";
                return Name + " isimli öğrencinin not ortalaması: " + Average.ToString() + " Not Puanı: " + AverageScore + "\nÖğrenci " + StudentPass;
            }
            else
            {
                return "Not girilmemiş";
            }
        }


    }
}
