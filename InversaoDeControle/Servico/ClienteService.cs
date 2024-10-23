using InversaoDeControle.Dominio.Contratos.Repositorios;
using InversaoDeControle.Dominio.Contratos.Servicos;
using InversaoDeControle.Dominio.Entidades;
using InversaoDeControle.Infra.Repositorios;
using System;

namespace InversaoDeControle.Servico
{
    internal class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteService(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public Cliente GetCliente()
        {
            return new Cliente();
        }

        public void AdicionaCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                Console.WriteLine("Cliente invalido");
            }
            
            _clienteRepositorio.AdicionaCliente(cliente);
            //salva no banco 
            //Envia Email
        }

    }
}
