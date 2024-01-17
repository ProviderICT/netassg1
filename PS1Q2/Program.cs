using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1Q2
{
    class Indexer
    {
        public string[] val = new string[3];
        public string[] indic = { "name", "rollno", "email" };
        public string this[string index]
        {
            get
            {
                return val[Array.IndexOf(indic, index)];
            }
            set
            {
                val[Array.IndexOf(indic, index)] = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Indexer indexer = new Indexer();
            indexer["name"] = "Bhagyashree";
            indexer["rollno"] = "17";
            indexer["email"] = "bhagyashree@gmail.com";

            Console.WriteLine("Answer2");
            Console.WriteLine("Name = {0}" , indexer["name"]);
            Console.WriteLine("Roll NO = {0}", indexer["rollno"]);
            Console.WriteLine("Email = {0}", indexer["email"]);

            Console.ReadLine();
        }
    }
}
