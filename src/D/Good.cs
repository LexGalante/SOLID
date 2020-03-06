using System;
using System.Collections.Generic;
using System.Text;

namespace D.Good
{
    public interface IConfiguracao
    {

    }

    public class Configuracao : IConfiguracao
    {

    }

    public class ConexaoSql
    {
        private readonly IConfiguracao _configuracao;

        public ConexaoSql(IConfiguracao configuracao)
        {
            _configuracao = configuracao;
        }
    }
}
