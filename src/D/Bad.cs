using System;

namespace D.Bad
{
    public class Configuracao
    {

    }

    public class ConexaoSql
    {
        private readonly Configuracao _configuracao;

        public ConexaoSql(Configuracao configuracao)
        {
            _configuracao = configuracao;
        }
    }
}
