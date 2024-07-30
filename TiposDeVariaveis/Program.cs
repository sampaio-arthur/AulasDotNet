using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Guys");

            // Exemplos com tipos de variáveis
            int num1 = 10;
            double num2 = 7.5;
            var soma = num1 + num2;
            Console.WriteLine("10 + 7.5 = " + soma);

            int copiaDeNum1 = num1;
            copiaDeNum1 = 20;
            Console.WriteLine(num1);
            Console.WriteLine(copiaDeNum1);

            // Exemplo com classe Quadrado
            var quadrado1 = new Quadrado();
            quadrado1.lado = 10;
            var quadrado2 = quadrado1;
            quadrado2.lado = 20;
            Console.WriteLine(quadrado1.lado);
            Console.WriteLine(quadrado2.lado);


        }
    }
}
