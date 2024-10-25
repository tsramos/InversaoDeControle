using InversaoDeControle.Dominio.Contratos.Repositorios;
using InversaoDeControle.Dominio.Contratos.Servicos;
using InversaoDeControle.Dominio.Entidades;
using InversaoDeControle.Infra.Repositorios;
using InversaoDeControle.Servico;
using System;

namespace InversaoDeControle.Web.Controllers
{
    internal class ClienteController
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public void AdicionaCliente(string nome, DateTime nascimento, string email)
        {
            Cliente cliente = new Cliente(nome, nascimento, email);
            _clienteService.AdicionaCliente(cliente);
        }
    }
}