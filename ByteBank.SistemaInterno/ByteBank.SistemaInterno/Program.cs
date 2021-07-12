using ByteBank.Modelos.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(4587, 4558779);
            Console.WriteLine(conta.Saldo);

            conta.Sacar(-10);

            Console.ReadLine();
        }
    }
}
