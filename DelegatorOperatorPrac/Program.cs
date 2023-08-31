using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorOperatorPrac
{
    class Program
    {
        public delegate void SendString(string message);
        static void Main(string[] args)
        {
            SendString sayHello, sayGoodbye, multiDelegate;
            sayHello = Hello;
            sayGoodbye = GoodBye;
            multiDelegate = sayHello + sayGoodbye;
            multiDelegate("김윤서");
            multiDelegate -= sayGoodbye;
            multiDelegate("김윤서");
        }

        private static void GoodBye(string message)
        {
            Console.WriteLine("안녕히가세요, " + message + "양..!");
        }

        private static void Hello(string message)
        {
            Console.WriteLine("안녕하세요, " + message + "양..!");
        }
    }
}
