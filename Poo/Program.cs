using System;
using System.Numerics;

namespace Poo
{
    class Program
    {
        static void Main()
        {
            ContaBancaria c1 = new ContaBancaria();
            ContaBancaria c2 = new ContaBancaria();

            c1.numConta = 4567;
            c2.numConta = 8900;
            c1.titular = "Arthur";
            c2.titular = "Matheus";
            
            c1.Depositar(200);
            c1.Depositar(50);
            c1.Sacar(150);

            c2.Depositar(1000);
            c2.Sacar(100);

            c2.Transferir(200, c1);

            Console.WriteLine(c1.numConta + "=>" + c1.saldo);
            Console.WriteLine(c2.numConta + "=>" + c2.saldo);
            Console.ReadLine();
        }
    }
}

    