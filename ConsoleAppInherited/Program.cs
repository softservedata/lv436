using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInherited
{
    public abstract class A
    {
        //public int i;
        private int i;

        public A()
        {
            i = 123;
            Console.WriteLine("public A() done");
        }

        public A(int i) // overload
        {
            this.i = i;
            Console.WriteLine("public A(int i) done");
        }

        public int GetI()
        {
            return i;
        }
    }

    public class B : A
    {
        public int j;

        public B()
        {
            Console.WriteLine("public B() done");
        }

        public int GetJ()
        {
            return j;
        }
    }

    public class Program
    {
        //private static int i;
        //private int k;

        //public Program(int k)
        //{
        //    this.k = k;
        //}

        //public void m1()
        //{
        //    Console.WriteLine("m1() k=" + k);
        //}

        public static void Main(string[] args)
        {
            //Program p = new Program(12);
            //Program p2 = new Program(22);
            //i = 11;
            //p.k = 13;
            //Console.WriteLine("done i = " + i.ToString() + "  p.k = " + p.k + "  p2.k = " + p2.k);
            //p.m1();
            //p2.m1();
            //
            B b = new B();
            b.j = 321;
            //Console.WriteLine("i=" + b.i + "  j=" + b.j);
            Console.WriteLine("i=" + b.GetI() + "  j=" + b.j);
        }
    }
}
