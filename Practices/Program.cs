using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            //var formatter = new BasimEviYazicisi();
            //var book = new Book(formatter);
            //book.Name = "Kitap";
            //book.Author = "M.Enes Karaca";
            //book.Print();


        }
//delegate


        public class Book : ManuScript
        {
            public string Name { get; set; }
            public string Author { get; set; }

            public override void Print()
            {
                Console.WriteLine(_formatter.Format());
                Console.WriteLine(Name + " " + Author);
            }

            public Book(IFormatter formatter) : base(formatter)
            {

            }

        }
        public class Document : ManuScript
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public override void Print()
            {
                Console.WriteLine(_formatter.Format());
                Console.WriteLine(Title + " " + Author);
            }
            public Document(IFormatter formatter) : base(formatter)
            {

            }
        }

        public abstract class ManuScript
        {
            protected IFormatter _formatter;
            public ManuScript(IFormatter formatter)
            {
                this._formatter = formatter;
            }

            public abstract void Print();
        }
        public interface IFormatter
        {
            string Format();
        }

        public class BasimEviYazicisi : IFormatter
        {
            public string Format()
            {
                return "M.Enes Karaca Basim Evi";
            }
        }
    }
}
