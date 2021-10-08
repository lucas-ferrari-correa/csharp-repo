using System;
using TesteCsharp.Classes;

namespace TesteCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int agencia = 222;
            int numeroDaConta = 11111;

            var banco = new Banco();
            bool criarMaisConta = false;

            while (!criarMaisConta)
            {
                var contaPoupanca = new ContaPoupanca(agencia, numeroDaConta);
                var contaCorrente = new ContaCorrente(agencia, numeroDaConta);

                banco.ContasBanco.Add(contaPoupanca);
                banco.ContasBanco.Add(contaCorrente);

                if (true)
                {
                    criarMaisConta = true;
                }
            }

            foreach (var contaBanco in banco.ContasBanco)
            {
                Console.WriteLine(contaBanco);
            }
        }   
    }
}
