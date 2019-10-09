using System;

namespace Tuples
{
    class Program
    {

        private static Random rnd;

        private static object[] GetStuff()
        {
            object[] objs = new object[3];
            objs[0] = rnd.Next();
            objs[1] = rnd.NextDouble();
            objs[2] = rnd.NextDouble() < 0.5;

            return objs;
        }
        private static DoStuff DoStuffz()
        {
            return new DoStuff(rnd.Next(), rnd.NextDouble(), rnd.NextDouble()< 0.5);
        }

        private static void GetStuff2(out int a, out double b, out bool c)
        {
            a = rnd.Next();
            b = rnd.NextDouble();
            c = rnd.NextDouble() < 0.5;
        }

        private static Tuple<int, double, bool> GetStuff3()
        {
            Tuple<int, double, bool> tuples = new Tuple<int, double, bool>(rnd.Next(), rnd.NextDouble(), rnd.NextDouble() < 0.5) ;

            return tuples;
        }

        static void Main(string[] args)
        {

            rnd = new Random();
            object[] firstObjects = GetStuff();

            Console.WriteLine("________________");

            foreach (object objectz in firstObjects)
                Console.WriteLine(objectz);

            Console.WriteLine("________________");


            DoStuff doThis = DoStuffz();

            Console.WriteLine(Convert.ToString(doThis.Inteiro));
            Console.WriteLine(Convert.ToString(doThis.Duplo));
            Console.WriteLine(Convert.ToString(doThis.Booleano));

            Console.WriteLine("________________");

            int a;
            double b;
            bool c;

            GetStuff2(out a, out b, out c);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine("________________");

            Tuple<int, double, bool> tuplez = GetStuff3();

            Console.WriteLine(tuplez.Item1);
            Console.WriteLine(tuplez.Item2);
            Console.WriteLine(tuplez.Item3);

            Console.WriteLine("________________");

        }
    }
}
