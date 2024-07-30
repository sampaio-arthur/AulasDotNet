using System;

namespace LacosDeRepeticaoCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // lacos condicionais => execucao mediante determinada condicao satisfeita
            int hora = 15;
            if (hora >= 15)
                Console.WriteLine("Ja sao 15 horas ou mais!");

            if (hora >= 18 || hora == 10)
                Console.WriteLine("A hora eh maior ou igual a 18 OU eh igual a 10");
            else if (hora <= 15)
                Console.WriteLine("A hora eh menor ou igual a 15 ");
            else
                Console.WriteLine("Ja passou das 15 horas");

            switch (hora) // geralmente se usa o switch com constantes
            {
                case 15: //o teste condicional aqui eh exato
                    Console.WriteLine("Sao 15 horas!");
                    break;
                case 18:
                    Console.WriteLine("Sao 18!");
                    break;
            }

            PrimeiroSemestre mes = PrimeiroSemestre.Maio;
            if (mes == PrimeiroSemestre.Maio)
            {
                Console.WriteLine("Estamos em maio com if!");
            }

            switch (mes)
            {
                case PrimeiroSemestre.Janeiro:
                    Console.WriteLine("Estamos em janeiro!");
                    break;
                case PrimeiroSemestre.Fevereiro:
                    Console.WriteLine("Estamos em fevereiro");
                    break;
                case PrimeiroSemestre.Marco:
                    Console.WriteLine("Estamos em marco!");
                    break;
                case PrimeiroSemestre.Abril:
                    Console.WriteLine("Estamos em abril!");
                    break;
                default: // sera executado se nenhum for satisfeito
                    Console.WriteLine("Nao eh nenhum desses meses!");
                    break;
            }
        }
    }

    public enum PrimeiroSemestre
    {
        Janeiro, Fevereiro, Marco, Abril, Maio, Junho
    }
}
