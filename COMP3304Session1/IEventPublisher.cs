using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    public interface IEventPublisher
    {
        /// <summary>
        /// Subscribe a listener to note events
        /// </summary>
        /// <param name="key">Refers to the note</param>
        /// <param name="listener">Reference to the listener method</param>
        void Subscribe(int key, EventHandler<NoteEventArgs> listener);

        /// <summary>
        /// Unsubscribe a listener from note events.
        /// </summary>
        /// <param name="key">Refers to the note</param>
        /// <param name="listener">Reference to the listener method</param>
       void Unsubscribe(int key,EventHandler<NoteEventArgs> listener);

        // why does IeEventPublisher take notekeys as parameter
        //because the the methods call the subscribe methods within dataelement that acts on a private event
        //for encapsulation
    }
}
