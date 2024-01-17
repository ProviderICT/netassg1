using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1Q3
{
    public abstract class JPDawar
    {
        public string Name { get; set; }
        public JPDawar(string name)
        {
            Name = name;
        }
        public abstract void Feild();
    }

    public class ICT : JPDawar
    {
        public string ictsubject { get; set; }
        public ICT(string name, string subject) : base(name)
        {
            ictsubject = subject;
        }

        public override void Feild()
        {
            Console.WriteLine($"My name is {Name} from JPDawer, and I am from Ict and my subject is {ictsubject}");
        }
    }

    public class IT : JPDawar
    {
        public string itsubject { get; set; }
        public IT(string name, string subject) : base(name)
        {
            itsubject = subject;
        }

        public override void Feild()
        {
            Console.WriteLine($"My name is {Name} from JPDawer, and I am from Ict and my subject is {itsubject}");
        }
    }

    internal class Program
    {
       
        static void Main(string[] args)
        {
            List<JPDawar> list = new List<JPDawar>();
            list.Add(new ICT("Bhagyashree", "Dotnet"));
            list.Add(new ICT("Praveen", "Java"));
            list.Add(new IT("Kinal", "Python"));
            list.Add(new IT("Bhuwan", "Hacker"));

            foreach(JPDawar jpd in list)
            {
                jpd.Feild();
                Console.ReadLine();
            }
        }
    }
}
