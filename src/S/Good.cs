using System;
using System.Collections.Generic;
using System.Text;

namespace S
{
    public class GerenciarConexao
    {
        public void AbrirConexaoComBanco() => throw new NotImplementedException();

        public void FecharConexaoComBanco() => throw new NotImplementedException();
    }

    public class ComandosSql
    {
        public T ListaDados<T>() where T : class => throw new NotImplementedException();

        public T ExecutaComandoSql<T>() where T : class => throw new NotImplementedException();
    }

    public class Configuracao
    {
        public void PegaArquivoConfiguracao() => throw new NotImplementedException();

        public void LerArquivoConfiguracao() => throw new NotImplementedException();
    }
}
