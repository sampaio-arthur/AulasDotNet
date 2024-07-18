using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LacosDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de laco for
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("valor de i eh:" + i);
            }

            // Exemplo de while
            int contador = 3;
            while (contador < 10)
            {
                contador += 1;
                Console.WriteLine(contador);
            }

            // Exemplo de do .. while
            double j = 10;
            double j1 = 10;
            do
            {
                Console.WriteLine(j);
                j *= 1.5;
            } while (j < 100);

            // Verificação das duas formas
            double fj = (j *= 1.5);
            double fj1 = (j1 = j1 * 1.5);
            bool isEqual = fj == fj1;
            Console.WriteLine(isEqual);

            // Exemplo de foreach
            int[] conjunto = { 1, 2, 3, 4, 10, 9, 50, 7 };
            foreach (int i in conjunto)
            {
                Console.WriteLine("esse elemento tem valor:" + i);
            }
        }
    }
}
