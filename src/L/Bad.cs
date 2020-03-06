using System;

namespace L.Bad
{
    public interface INada
    {
        T TenhoQueFazerUmMonteDeCoisa<T>() where T : class;
    }

    public class NaoFacoNada : INada
    {
        public T TenhoQueFazerUmMonteDeCoisa<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
