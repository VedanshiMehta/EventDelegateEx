using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateEx
{
    
    class AddBuiltinEvent
    {
        public event EventHandler<EventArgs> Addnumbers;

        public void Add()
        {
            int x;
            x = 100 + 150;
            Console.WriteLine("\n Event Add " + (x));
            Console.Read();
            OnCompletedEvent();

        }

        private void OnCompletedEvent()
        {
            Addnumbers?.Invoke(this,EventArgs.Empty);
            Console.Read();
        }
    }
}
