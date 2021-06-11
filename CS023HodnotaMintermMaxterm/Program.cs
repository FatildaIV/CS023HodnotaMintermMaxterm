using System;

namespace CS023HodnotaMintermMaxterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} » Hodnota Mintermu: {1}", "+A-B-C", HodnotaMintermu("+A-B-C"));
            Console.WriteLine("{0} » Hodnota Mintermu: {1}", "+A+B-C-D", HodnotaMintermu("+A+B-C-D"));
            Console.WriteLine("{0} » Hodnota Maxtermu: {1}", "+A-B-C", HodnotaMaxtermu("+A-B-C"));
            Console.WriteLine("{0} » Hodnota Maxtermu: {1}", "+A+B-C-D", HodnotaMaxtermu("+A+B-C-D"));
            Console.ReadKey();
        }

        // Hodnota Mintermu +A-B-C => 100 ; +A+B-C-D => 1100 ;
        static string HodnotaMintermu(string logickyClen)
        {
            string hodnota = "";
            for (int i = 0; i < logickyClen.Length; i = i + 2)
            {
                if(logickyClen[i] == '+')
                {
                    hodnota += "1";
                }
                if (logickyClen[i] == '-')
                {
                    hodnota += "0";
                }
            }
            return hodnota;
        // Hodnota Maxtermu +A-B-C => 011 ; +A+B-C-D => 0011 ;
        }
        static string HodnotaMaxtermu(string logickyClen)
        {
            string hodnota = "";
            for (int i = 0; i < logickyClen.Length; i = i + 2)
            {
                if(logickyClen[i] == '+')
                {
                    hodnota += "0";
                }
                if (logickyClen[i] == '-')
                {
                    hodnota += "1";
                }
            }
            return hodnota;
        }

    }
}
