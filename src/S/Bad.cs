using System;

namespace S
{
    public class Bad
    {
        public void AbrirConexaoComBanco() => throw new NotImplementedException();

        public void FecharConexaoComBanco() => throw new NotImplementedException();

        public T ListaDados<T>() where T: class => throw new NotImplementedException();

        public T ExecutaComandoSql<T>() where T : class => throw new NotImplementedException();

        public void PegaArquivoConfiguracao() => throw new NotImplementedException();

        public void LerArquivoConfiguracao() => throw new NotImplementedException();
    }
}
