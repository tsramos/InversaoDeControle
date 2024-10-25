
using InversaoDeControle.Dominio.Contratos.Email;
using InversaoDeControle.Dominio.Contratos.Repositorios;
using InversaoDeControle.Dominio.Contratos.Servicos;
using InversaoDeControle.Infra.Repositorios;
using InversaoDeControle.Servico;
using Microsoft.Extensions.DependencyInjection;

namespace InversaoDeControle
{
    internal static class Startup
    {
        public  static void InjeteDependencias()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();            
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IEmailService, EmailService>();
        }
    }
}
