using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParam
{
    public class MyType
    {
        private int amount;
        public int Amount { get { return amount; } set { amount = value; } }
        //
        //private string message;
        public string Message { get; set; }

        public MyType(int amount, string message)
        {
            Amount = amount;
            Message = message;
        }
    }

    public class Program
    {
        public delegate double Action(double x);
        public delegate double Action2(double x, double y);
        public double Sqr(double x)
        {
            return x * x;
        }

        public double SqrP1(double x)
        {
            return x * x + 10;
        }

        private double Work(Action f, double x)
        {
            Console.WriteLine("Work running");
            return f(x) + 1;
        }

        public double Work2(Action2 f, double x, double y)
        {
            Console.WriteLine("Work2 running");
            return f(x, y);
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        public void work1(int i)
        {
            i = i + 1;
            Console.WriteLine("work1(int i), i = " + i);
        }

        public void work2(ref int i)
        {
            i = i + 1;
            Console.WriteLine("work2(ref int i), i = " + i);
        }

        public void work1(StringBuilder sb) // Overload
        {
            sb.Append(" 1234");
            Console.WriteLine("work1(StringBuilder sb)), sb = " + sb);
            sb = new StringBuilder("Ha-Ha-Ha");
            Console.WriteLine("work1(StringBuilder sb)), new sb = " + sb);
        }

        public void work2(ref StringBuilder sb)
        {
            sb.Append(" 1234");
            Console.WriteLine("work2(ref StringBuilder sb), sb = " + sb);
            sb = new StringBuilder("Ha-Ha-Ha");
            Console.WriteLine("work2(ref StringBuilder sb), new sb = " + sb);
        }

        public void work1(string s) // Overload
        {
            s = s + " 123";
            Console.WriteLine("work1(string s), s = " + s);
        }

        public void work2(ref string s)
        {
            s = s + " 123";
            Console.WriteLine("work2(ref string s), s = " + s);
        }

        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public static void Main(string[] args)
        {
            Program appl = new Program();
            //
            // By Value/ Primitive(value) type
            //int i = 1;
            //Console.WriteLine("main(), start i = " + i);
            //appl.work1(i);
            //Console.WriteLine("main(), after i = " + i);
            //
            // By Reference/Primitive(value) type
            //int i = 1;
            //Console.WriteLine("main(), start i = " + i);
            //appl.work2(ref i);
            //Console.WriteLine("main(), after i = " + i);
            //
            // By Value/Reference type
            //StringBuilder sb = new StringBuilder("abc");
            //Console.WriteLine("main(), start sb = " + sb);
            //StringBuilder sb0 = sb;
            //Console.WriteLine("main(), start sb0 = " + sb0);
            //appl.work1(sb);
            //Console.WriteLine("main(), after sb = " + sb);
            //Console.WriteLine("main(), start sb0 = " + sb0);
            //
            // By Reference/Reference type
            //StringBuilder sb = new StringBuilder("abc");
            //Console.WriteLine("main(), start sb = " + sb);
            //StringBuilder sb0 = sb;
            //Console.WriteLine("main(), start sb0 = " + sb0);
            //appl.work2(ref sb);
            //Console.WriteLine("main(), after sb = " + sb);
            //Console.WriteLine("main(), start sb0 = " + sb0);
            //
            // By Value/Reference + Immutable type
            //String s = new String("abc");
            //string s = "abc";
            //Console.WriteLine("main(), start s = " + s);
            //string s0 = s;
            //Console.WriteLine("main(), start s0 = " + s0);
            //appl.work1(s);
            //Console.WriteLine("main(), after s = " + s);
            //Console.WriteLine("main(), after s0 = " + s0);
            //
            // By Reference/Reference + Immutable type
            //String s = new String("abc");
            //String s = "abc";
            //Console.WriteLine("main(), start s = " + s);
            //String s0 = s;
            //Console.WriteLine("main(), start s0 = " + s0);
            //appl.work2(ref s);
            //Console.WriteLine("main(), after s = " + s);
            //Console.WriteLine("main(), after s0 = " + s0);
            //
            // By Name
            //Action sqr1 = appl.Sqr;
            //Action sqr1 = new Action(appl.Sqr);
            //Console.WriteLine("Run Work(Sqr2, 10): " + appl.Work(sqr1, 10));
            //Console.WriteLine("Run Work(Sqr2, 10): " + appl.Work(appl.SqrP1, 10));
            //
            // Use Lambda
            //Action sqr2 = x => x * x; // Anonimous Method
            //Console.WriteLine("Run Work(Sqr2, 10): " + appl.Work(sqr2, 10));
            //Console.WriteLine("Run Work(Lambda, 10): " + appl.Work(x => x * x, 10));
            //Console.WriteLine("Run Work(Lambda, 10): " + appl.Work(x => { x++; return x * x; }, 10));
            //
            //Console.WriteLine("Run Work2(Lambda, 8, 9): " + appl.Work2((x, y) => { x++; y++; return x * y; }, 8, 9));
            //
            // Class MyType
            //MyType m = new MyType(108, "Hello");
            //Console.WriteLine("m.Amount= " + m.Amount + "  m.Message= " + m.Message);
            // Anonimous Class
            //var v = new { Amount = 108, Message = "Hello" };
            //Console.WriteLine("v.Amount= " + v.Amount + "  v.Message= " + v.Message);
            //
            // Linq
            string[] greetings = { "hello world", "hello LINQ", "hello C# LINQ" };
            //var items = from s in greetings where s.EndsWith("LINQ") select s;
            //foreach (var item in items)
            //foreach (var item in greetings)
            //{
            //    Console.WriteLine(item);
            //}
            //
            int id = 0;
            var items = greetings
                            .Where(c => c.EndsWith("LINQ"))
                            .Select(c => new { Id = ++id, Str = c });
            foreach (var item in items)
            {
                //Console.WriteLine("id= " + item.Id.ToString() + "  str= " + item.Str);
                Console.WriteLine("id= " + item.Id + "  str= " + item.Str);
            }
        }
    }
}
