using System;

namespace I.Bad
{
    public interface IClienteSql
    {
        bool BuscaClientes(object filtro);
        bool SalvaCliente(object cliente);
    }

    public class SomenteDeveBuscarCliente : IClienteSql
    {
        public bool BuscaClientes(object filtro)
        {
            //Estou buscando cliente na base de dados

            return true;
        }

        public bool SalvaCliente(object cliente)
        {
            //só implemento isso pq é obrigatorio
            throw new NotImplementedException();
        }
    }
}
