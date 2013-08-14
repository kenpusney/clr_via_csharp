using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLR_via_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("abc".parse());
            Console.Read();
        }
    }
    static class A {
        public static int parse(this string b) {
            return b.Length;
        }
        public static int parse(this B b) {
            return b.Length;
        }
    }
    class B {
        public int Age { get; set; }
    }
}
