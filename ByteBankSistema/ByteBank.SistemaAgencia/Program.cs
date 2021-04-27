using ByteBank.Modelos;
using ByteBank.Modelos.Contas;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
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
            string url = "pagina?argumentos";

            Console.WriteLine(url);
            
            string argumentos = url.Substring(6);
            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}
