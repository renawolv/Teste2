using System;

namespace Teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInicial = 1;
            int numFinal = 100;

            ExibirNumero(numInicial, numFinal);

            Console.ReadLine();
        }

        public static void ExibirNumero(int numInicial, int numFinal)
        {
            if (numInicial <= numFinal)
            {
                Console.Write(numInicial + " ");
                ExibirNumero(numInicial + 1, numFinal);
            }
        }
    }
}
