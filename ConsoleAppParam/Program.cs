using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParam
{
    public class Program
    {
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
        }
    }
}
