using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ahmet");
            student.Name = "Mehmet";
            student.Score = new int[3];
            student.Score[0] = 80;
            student.Score[1] = 65;
            student.Score[2] = 45;
            student.Calculate();
            Console.WriteLine(student.ShowResult());
            //Console.Write(student.CalculateCounter);

            Student student1 = new Student("Arda");
            student1.Score = new int[4];
            student1.Score[0] = 15;
            student1.Score[1] = 20;
            student1.Score[2] = 40;
            student1.Score[3] = 30;
            Console.WriteLine(student1.ShowResult());

            Console.WriteLine(false.ToString());
            Console.WriteLine(DateTime.Now.Date);

        }
    }
}
