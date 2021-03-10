using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    public interface IFactory<E>
    {
        /// <summary>
        /// Instantiate the class of T where interface E applies. E is described when the factory is called.
        /// </summary>
        /// <typeparam name="T">The class to be instantiated</typeparam>
        /// <returns>The an instance of T</returns>
        E Create<T>() where T : E, new();

    }
}
