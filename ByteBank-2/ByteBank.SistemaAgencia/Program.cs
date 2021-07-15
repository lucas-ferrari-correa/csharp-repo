using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679788));
            lista.Adicionar(new ContaCorrente(874, 5679789));
            lista.Adicionar(new ContaCorrente(874, 5679789));
            lista.Adicionar(new ContaCorrente(874, 5679789));
            lista.Adicionar(new ContaCorrente(874, 5679789));
            lista.Adicionar(new ContaCorrente(874, 5679789));
            lista.Adicionar(new ContaCorrente(874, 5679789));
            lista.Adicionar(new ContaCorrente(874, 5679789));
            lista.Adicionar(new ContaCorrente(874, 5679789));
            lista.Adicionar(new ContaCorrente(874, 5679789));
            lista.Adicionar(new ContaCorrente(874, 5679789));
            lista.Adicionar(new ContaCorrente(874, 5679789));


            Console.ReadLine();
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4445556),
                    new ContaCorrente(874, 6659877)
                };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            int[] idades = new int[5];
            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }
    }


}
