using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInherited
{
    /*
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
        */

    public class ClassA
    {
        public int i = 1;
        public virtual int J { get; set; }
        //
        //private int j;
        //public int J {
        //    get { return j; }
        //    set { j = value; }
        //}
            
        public ClassA()
        {
            J = 11;
            Console.WriteLine("\t\tConstructor A() DONE, J = " + J);
        }

        public virtual void m1()
        {
            Console.WriteLine("ClassA, metod m1, i={0}", i);
        }
        public void m2()
        {
            Console.WriteLine("ClassA, metod m2, i={0} J={1}", i, J);
        }
        public void m3()
        {
            Console.Write("ClassA, metod m3, runnind m4(): ");
            m4();
            m5();
        }
        public virtual void m4()
        {
            Console.WriteLine("ClassA, metod m4");
        }

        //private void m5()
        protected virtual void m5()
        {
            Console.WriteLine("ClassA, PRIVATE metod m5");
        }

    }

    public class ClassB : ClassA
    {
        public new double i = 1.1;
        public override int J { get; set; }

        public ClassB() //:base()
        {
            J = 22;
            Console.WriteLine("\t\tConstructor B() DONE, J = " + J);
        }

        public override void m1()
        {
            //Console.WriteLine("Running m1 from class A:");
            //base.m1();
            //
            Console.WriteLine("ClassB, metod m1, i={0}", i);
        }
        public new void m2()
        {
            Console.WriteLine("ClassB, metod m2, i={0}", i);
        }
        public override void m4()
        {
            Console.WriteLine("ClassB, metod m4");
            m5();
        }

        public void m6()
        {
            Console.WriteLine("ClassB, metod m6");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The Start.");
            //- - - - - - - - - - - - -
            //ClassA a;
            //a = new ClassA();
            //Console.WriteLine("Test ClassA.");
            //a.m1();
            //a.m2();
            //a.m3();
            //a.m4();
            //a.m5(); // ERROR
            //- - - - - - - - - - - - -
            ClassA b;
            b = new ClassB();       // 1. Polymorphism, declare parent, create child
            Console.WriteLine("Test ClassB.");
            b.m1();                 // 2. Polymorphism, run form object if m1() virtual
            b.m2();                 // form A
            b.m3();                 // 3. Polymorphism, m3 run m4 from B
            b.m4();
            //b.m5(); //ERROR
            //b.m6(); //ERROR
            ((ClassB)b).m6(); // Code Smell
            //- - - - - - - - - - - - -
            //ClassB b0;
            //b0 = new ClassB();
            //Console.WriteLine("Test_0 ClassB.");
            //b0.m1();
            //b0.m2();
            //b0.m3();
            //b0.m4();
            //b0.m6();
            //- - - - - - - - - - - - -
            Console.WriteLine("The End.");
        }
    }

}
