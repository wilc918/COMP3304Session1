using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    public interface IServiceLocator
    {
        /// <summary>
        /// Return a concrete factory for creating a given type.
        /// </summary>
        /// <typeparam name="T">The type of the abstraction (ie abstract class or interface) of the required class</typeparam>
        /// <returns></returns>
        IService Get<T>() where T : class;
    }
}
