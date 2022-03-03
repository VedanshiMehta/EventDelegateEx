using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateEx
{
    public delegate void Start();
    class StartProgram
    {

        public event Start completedProcess;
           
        public void StartProcess()
        {
           
            
            Console.WriteLine("Process started");
            Console.ReadLine();
            OncompletedProcess();
        }

        private void OncompletedProcess()
        {
            completedProcess?.Invoke();
        }
    }
}
