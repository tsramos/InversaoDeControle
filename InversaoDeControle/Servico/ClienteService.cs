using InversaoDeControle.Dominio.Contratos.Email;
using InversaoDeControle.Dominio.Contratos.Repositorios;
using InversaoDeControle.Dominio.Contratos.Servicos;
using InversaoDeControle.Dominio.Entidades;
using Microsoft.Extensions.Logging;
using System;

namespace InversaoDeControle.Servico
{
    internal class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly IEmailService _emailService;
        private readonly ILogger<ClienteService> _logger;

        public ClienteService(IClienteRepositorio clienteRepositorio,
                              IEmailService emailService,
                              ILogger<ClienteService> logger)
        {
            _clienteRepositorio = clienteRepositorio;
            _emailService = emailService;
            _logger = logger;
        }

        public Cliente GetCliente()
        {
            return new Cliente("nome", new DateTime(), "email");
        }

        public void AdicionaCliente(Cliente cliente)
        {
            //Valida cliente
            if (cliente == null)
            {
                _logger.LogError("Erro ao adicionar cliente, cliente nulo");
            }
            
            _clienteRepositorio.AdicionaCliente(cliente);
            _logger.LogInformation("Cliente adicionado a base de dados");
            //salva no banco 

            //Envia Email
            _logger.LogWarning("Tentando enviar email");
            _emailService.EnviaEmailBoasVindas("atendimento@techclass.dev.br", cliente.Email, "Bem vindo");
        }

    }
}
