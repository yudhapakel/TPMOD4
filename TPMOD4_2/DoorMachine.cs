using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4_2
{
    internal class DoorMachine
    {
        private enum State { Terkunci, Terbuka }
        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("pintu terkunci");
        }

        public void KunciPintu()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
}
