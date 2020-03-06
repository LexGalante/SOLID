using System;
using System.Collections.Generic;
using System.Text;

namespace I
{
    public interface ISalvaCliente
    {
        bool SalvaCliente(object cliente);
    }

    public class SalvaCliente : ISalvaCliente
    {
        bool ISalvaCliente.SalvaCliente(object cliente)
        {
            throw new NotImplementedException();
        }
    }

    public interface IBuscaCliente
    {
        object BuscaCliente(object filtro);
    }

    public class BuscaCliente : IBuscaCliente
    {
        object IBuscaCliente.BuscaCliente(object filtro)
        {
            throw new NotImplementedException();
        }
    }
}
