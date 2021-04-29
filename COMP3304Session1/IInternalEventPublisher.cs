﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    /// <summary>
    /// Enforce the implementation of subscription methods for direct data handling with event listeners
    /// </summary>
    public interface IInternalEventPublisher
    {

        /// <summary>
        /// Subscribe a listener to note events
        /// </summary>
        /// <param name="listener">Reference to listener method</param>
        void Subscribe(EventHandler<NoteEventArgs> listener);

        /// <summary>
        /// Unsubscribe a listener from note events
        /// </summary>
        /// <param name="listener">Reference to listener method</param>
        void Unsubscribe(EventHandler<NoteEventArgs> listener);
    }
}
