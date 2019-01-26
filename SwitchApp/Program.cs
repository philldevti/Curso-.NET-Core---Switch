using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Switch.Domain.Entities;
using Switch.Domain.Enums;
using Switch.Infra.CrossCutting.Logging;
using Switch.Infra.Data.Context;
using System;

namespace SwitchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = new Usuario()
            {
                Nome = "Usuario3",
                SobreNome = "SobreUsuario",
                Senha = "1234",
                Email = "usuario@teste.com",
                DataNascimento = DateTime.Now,
                Sexo = SexoEnum.Masculino,
                UrlFoto = "asdasdghasgdjhasgd"
            };

            var optionsBuilder = new DbContextOptionsBuilder<SwitchContext>();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql("Server=localhost;userid=root;password=1234;database=SwitchDB",
                                   m => m.MigrationsAssembly("Switch.Infra.Data"));

            try
            {
                using (var db = new SwitchContext(optionsBuilder.Options))
                {
                    db.GetService<ILoggerFactory>().AddProvider(new Logger());
                    db.Usuarios.Add(usuario);
                    db.SaveChanges();
                }
                Console.WriteLine("OK");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro", ex.Message);                
            }           

            Console.ReadKey();
        }
    }
}
