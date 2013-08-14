using System;

namespace CLR_via_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            a[8] = 64;

            Console.WriteLine(a[7]);
            Console.Read();
        }
    }
    class A { 
        private int _index = 0;
        public int this[int index]{
            get{ return _index* index;}
            set{ _index = index;}
        }
    }
}
