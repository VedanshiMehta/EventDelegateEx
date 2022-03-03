using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateEx
{
    public delegate int Sum(int x, int y);
    class SumEventDelegate
    {
        public event Sum Plus;
        public void Process()
        {
            Console.WriteLine("\n Process Strated");
            Console.ReadLine();
            OnSumProcess();
        
        }

        private void OnSumProcess()
        {
            Plus.Invoke(20,30);
            Console.Read();
        }
    }
}
