using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeusLivrosAPI.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MeusLivrosAPI.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (context.Livros.Any())
                {
                    context.Livros.AddRange(new Livros()
                    {
                        Titulo = "Tecnologia",
                        Descricao = " Core",
                        IsRead = true,
                        DataLeitura = DateTime.Now.AddDays(-10),
                        Avaliacao = 5,
                        Genero = "AlgoritimoCore",
                        CoverUrl = "https....",
                        DataAdicao = DateTime.Now
                    },
                    new Livros()
                    {
                        Titulo = "Engenharia de Software",
                        Descricao = "Engenharia_Software_3Edicao_sommerville",
                        IsRead = true,
                        DataLeitura = DateTime.Now.AddDays(-10),
                        Avaliacao = 5,
                        Genero = "Engenharia_Software",
                        CoverUrl = "https....",
                        DataAdicao = DateTime.Now
                    });
                    context.SaveChanges();
                }

            }
        }

    }
}
