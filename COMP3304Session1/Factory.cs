using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    /// <summary>
    /// Implementation of a factory that returns implementations of a specific abstraction (eg interface)
    /// </summary>
    /// <typeparam name="E"> The specfic abstraction required (a constraint)(aka the type of whats being made eg IAnimal)</typeparam>
    public class Factory<E> : IFactory<E>
    {
        /// <summary>
        /// Instantiate and return an object that supports the interface E (eg IAnimal)
        /// </summary>
        /// <typeparam name="T">The class to be instantiated. (eg Lion)</typeparam>
        /// <returns>Returns new instance of type T</returns>
        public E Create<T>() where T : E, new()
        {
            return new T();
        }
    }
}
