using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    /// <summary>
    /// Enforce the implementation of the event handler
    /// </summary>
    interface IEventListener
    {
        /// <summary>
        /// Definition of the event handler method
        /// </summary>
        /// <param name="source">The Caller</param>
        /// <param name="args">The event message</param>
        void OnNewInput(object source, NoteEventArgs args);
    }
}
