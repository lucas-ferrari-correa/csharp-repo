using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //select * from actor

            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                

                System.Console.ReadLine();
            }
        }

        static void StoredProcedure(DbContext contexto)
        {
            var categoria = "Action"; // 36

            var paramCategoria = new SqlParameter("category_name", categoria);
            var paramTotal = new SqlParameter
            {
                ParameterName = "@total_actors",
                Size = 4,
                Direction = System.Data.ParameterDirection.Output
            };
            contexto.Database
                .ExecuteSqlCommand("execute total_actors_from_given_category @category_name, @total_actors OUT", paramCategoria, paramTotal);

            System.Console.WriteLine($"O total de atores na categoria {categoria} é de {paramTotal.Value}.");
        }
    }
}