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
            DateTime dataFimPagamento = new DateTime(2021, 5, 29);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            Console.WriteLine("Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca));

            Console.ReadLine();
        }

        //static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        //{
        //    if (timeSpan.Days > 30)
        //    {
        //        int quantidadeMeses = timeSpan.Days / 30;
                
        //        if (quantidadeMeses == 1)
        //        {
        //            return "1 mês";
        //        }

        //        return quantidadeMeses + " meses";
        //    }

        //    if (timeSpan.Days > 7)
        //    {
        //        int quantidadeSemanas = timeSpan.Days / 7;
        //        return quantidadeSemanas + " semanas";
        //    }

        //    return timeSpan.Days + " dias";
        //}
    }
}
