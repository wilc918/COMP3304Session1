using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    public class NoteEventArgs : EventArgs
    {
        /// <summary>
        /// Property to hold the updated text (if any)
        /// </summary>
        public String text { get; }

        /// <summary>
        /// Property to hold the updated image (if any)
        /// </summary>
        public Image image { get; }

        /// <summary>
        /// Places text within variable.
        /// </summary>
        /// <param name="data">String we want to store</param>
        public NoteEventArgs(String data)
        {
            this.text = data;
        }

        /// <summary>
        /// Places image within variable
        /// </summary>
        /// <param name="data">Image we want to store</param>
        public NoteEventArgs(Image data) 
        {
            this.image = data;
        }
    }
}
