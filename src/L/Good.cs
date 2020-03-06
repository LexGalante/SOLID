using System;
using System.Collections.Generic;
using System.Text;

namespace L.Good
{
    public interface ITudo
    {
        T TenhoQueFazerUmMonteDeCoisa<T>() where T : class;
    }

    public class Tudo : ITudo
    {
        public T TenhoQueFazerUmMonteDeCoisa<T>() where T : class
        {
            while (true)
            {
                _ = DateTime.Now;
                Console.WriteLine(_);
            }
        }
    }
}
