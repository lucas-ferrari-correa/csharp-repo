﻿using ByteBank.Modelos;
using ByteBank.Modelos.Contas;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 489754);
            Funcionario funcionario = null;

            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
