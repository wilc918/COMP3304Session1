using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    public interface INoteData
    {
        /// <summary>
        /// Add a new note
        /// </summary>
        /// <param name="key">Unique key of new note</param>
        void AddItem(int key);

        /// <summary>
        /// Remove a note
        /// </summary>
        /// <param name="key">the identifier of the note to be removed</param>
        void RemoveItem(int key);
    }
}
