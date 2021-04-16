using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("Roberta", "111.111.111-12", 1000);
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("Camila", "111.111.111-14", 1000);
            camila.Senha = "abc";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("Pedro", "111.111.111-11", 2000);

            Funcionario roberta = new Diretor("Roberta", "111.111.111-12", 1000);

            Funcionario igor = new Auxiliar("Igor", "111.111.111-13", 1000);

            Funcionario camila = new GerenteDeConta("Camila", "111.111.111-14", 1000);

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
