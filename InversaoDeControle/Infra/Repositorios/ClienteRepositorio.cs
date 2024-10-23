using InversaoDeControle.Dominio.Contratos.Repositorios;
using InversaoDeControle.Dominio.Entidades;

namespace InversaoDeControle.Infra.Repositorios
{
    internal class ClienteRepositorio : IClienteRepositorio
    {
        public void AdicionaCliente(Cliente cliente)
        {
            //context.Set<Cliente>().Add(cliente);
            //context.SaveChanges();
        }
    }
}
