using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    public interface IEventListener
    {
        /// <summary>
        /// Event listener
        /// </summary>
        /// <param name="source">Who is calling</param>
        /// <param name="args">Message</param>
        void OnNewData(object source, NoteEventArgs args);

    }
}







