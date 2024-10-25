using InversaoDeControle.Web.Controllers;
using System;

namespace InversaoDeControle
{
    internal class Program
    {
        private readonly ClienteController _clienteController;

        public Program(ClienteController clienteController)
        {
            _clienteController = clienteController;
        }

        static void Main(string[] args)
        {
            Startup.InjeteDependencias();
           /*Como se fosse um front*/
           _clienteController.AdicionaCliente("nome", )
        }
    }
}
