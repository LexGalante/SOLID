using System;
using System.Data.Common;

namespace O
{
    public class ConexaoMsSqlServer
    {
        public DbConnection PegaConexaoMsSqlServer() => throw new NotImplementedException();
    }

    public class ConexaoOracle
    {
        public DbConnection PegaConexaoOracle() => throw new NotImplementedException();
    }

    public class ConexaoMySql
    {
        public DbConnection PegaConexaoMySql() => throw new NotImplementedException();
    }
}
