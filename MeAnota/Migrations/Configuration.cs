namespace MeAnota.Migrations
{
    using MeAnota.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MeAnota.Models.MeAnotaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MeAnota.Models.MeAnotaContext context)
        {
            var colaborador = new Usuario { Email = "colaborador@vintem.com.br", Nome = "Colaborador" };

            context.Usuarios.AddOrUpdate(u => u.Email, colaborador);

            var bloco = new Bloco { Nome = "Bloco 1" };
            context.Blocos.AddOrUpdate(b => b.Nome, bloco);

            var anotacao = new Anotacao { Titulo = "Anotacao 1", Texto = "Texto da anotacao 1" };
            context.Anotacoes.AddOrUpdate(a => a.Titulo, anotacao);

            bloco.Colaboradores.Add(colaborador);
            bloco.Anotacoes.Add(anotacao);
            context.Blocos.AddOrUpdate(bloco);
        }
    }
}
