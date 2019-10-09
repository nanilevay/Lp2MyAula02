using System;

namespace Tuples
{
    struct DoStuff
    {

        public int Inteiro { get; }
        public double Duplo { get; }
        public bool Booleano { get; }

        public DoStuff (int a, double d, bool b)
        {
            Inteiro = a;
            Duplo = d;
            Booleano = b;
        }

        
    }

}
