using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateEx
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram sp = new StartProgram();
            sp.completedProcess += Sp_completedProcess;
            sp.StartProcess();
        }

        private static void Sp_completedProcess()
        {
            Console.WriteLine("Welocme to the World of friends");
            Console.ReadLine();
        }
    }
}
