using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    /// <summary>
    /// Enforce the implementation of subscription methods for event listeners in regards to a dictionary
    /// </summary>
    public interface IEventPublisher
    {
        /// <summary>
        /// Subscribe a listener to note events
        /// </summary>
        /// <param name="key">Key to note</param>
        /// <param name="listener">Reference to the listener method</param>
        void Subscribe(int key, EventHandler<NoteEventArgs> listener);

        /// <summary>
        /// Unsubscribe a listener from note events
        /// </summary>
        /// <param name="key">Key to the note</param>
        /// <param name="listener">Reference to the listener method</param>
        void Unsubscribe(int key, EventHandler<NoteEventArgs> listener);
    }
}
