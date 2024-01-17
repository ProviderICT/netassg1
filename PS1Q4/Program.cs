using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1Q4
{
    interface Ictdepartment
    {
        void ictname();
    }
    interface Itdepartment
    {
        void itname();
    }

    class JPDawer : Ictdepartment ,Itdepartment
    {
        public void ictname()
        {
            Console.WriteLine("JP Dawer have the department of ICT ");

        }
        public void itname()
        {
            Console.WriteLine("JP Dawer have the department of IT ");
        }

       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            JPDawer jPDawer = new JPDawer();
            jPDawer.ictname();
            Console.ReadLine();
        }
    }
}
