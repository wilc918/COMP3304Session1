using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    /// <summary>
    /// Factory locator implementation - a Service Locator
    /// </summary>
    public class FactoryLocator : IServiceLocator
    {
        // DECLARE an IDictionary to contain references to IService objects, accessed via the Type that
        // Call it _factoryRegister:
        private IDictionary<Type, IService> _factoryRegister;

        /// <summary>
        /// Constructor of objects of type FactoryLocator.
        /// </summary>
        public FactoryLocator()
        {
            _factoryRegister = new Dictionary<Type, IService>();
        }

        public IService Get<T>() where T : class 
        {
            // Register factory if a factory for rqd Type is not yet registered
            if (!_factoryRegister.ContainsKey(typeof(T))) 
            {
                _factoryRegister.Add(typeof(T), new Factory<T>());
            }

            return _factoryRegister[typeof(T)];
        }


    }
}
