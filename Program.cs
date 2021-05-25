using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Simple_HWID_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string hwid = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
            Console.WriteLine("Your HWID is: " + hwid);
            Console.ReadKey();
        }
    }
}
