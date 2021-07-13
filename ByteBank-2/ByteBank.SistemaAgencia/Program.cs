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
            // pagina?argumentos
            // 012345678

            //string palavra = "moedaDestino=real";
            //int indice = palavra.IndexOf("real");
            //Console.WriteLine(indice);
            //Console.ReadLine();

            //string textoVazio = "";
            //string textoNulo = null;
            //string textoQualquer = "kjhfsdjhgsdfjksdf";


            //Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            //Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            //Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            //Console.ReadLine();


            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);

            string valor = extrator.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valor);


            Console.ReadLine();
        }
    }


}
