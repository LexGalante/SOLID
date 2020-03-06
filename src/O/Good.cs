using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace O.Good
{
    public interface IConexao
    {
        DbConnection PegaConexao();
    }

    public class ConexaoMsSqlServer : IConexao
    {
        public DbConnection PegaConexao() => throw new NotImplementedException();
    }

    public class ConexaoOracle : IConexao
    {
        public DbConnection PegaConexao() => throw new NotImplementedException();
    }

    public class ConexaoMySql : IConexao
    {
        public DbConnection PegaConexao() => throw new NotImplementedException();
    }
}
