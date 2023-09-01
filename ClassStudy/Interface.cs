using System;
using System.Collections.Generic;
using System.Text;

namespace ClassStudy
{
    interface Irun {
        abstract void Run();
        static void Test() {
            System.Console.WriteLine("Irun test");
        }
    }

    interface IFastRun : Irun {
        abstract void FastRun();
        static void Test1()
        {
            System.Console.WriteLine("IFastRun test1");
        }
    }

    interface Ffly {
        abstract void Fly();
    
    }
    class Bird1 : Ffly {
        public void Fly() {
            System.Console.WriteLine("bird  fly");
        }
    }

    class Bird2 : IFastRun {
        public void Run() {
            System.Console.WriteLine("bird2  Run");
        }
        public void FastRun() {
            System.Console.WriteLine("bird2  FastRun");
        }
    }
    class Interface
    {
        public static void Main() {
            Ffly fly = new Bird1();
            fly.Fly();
            System.Console.WriteLine("==========================");


        }
    }
}
