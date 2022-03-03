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

            SumEventDelegate sed = new SumEventDelegate();
            sed.Plus += Sed_Plus;
            sed.Process();

            AddBuiltinEvent abe = new AddBuiltinEvent();
            abe.Addnumbers += Abe_Addnumbers;
            abe.Add();
        }

        private static void Abe_Addnumbers(object sender, EventArgs e)
        {
            Console.WriteLine("\n Event is Executed.....");
           
        }

        private static int Sed_Plus(int x, int y)
        {

            Console.WriteLine( "\n x + y = "+ (x + y));
            return x + y;



        }

        private static void Sp_completedProcess()
        {
            Console.WriteLine("\n Welocme to the World of friends");
     
        }
    }
}
