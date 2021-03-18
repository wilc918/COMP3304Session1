using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    /// <summary>
    /// Sends off arguements constructed with data it retrieves from listeners
    /// </summary>
    public class NoteEventArgs : EventArgs
    {
  
        // Stores a string of text.
        private String _text;

        // Returns the string inside _text.
        public String Text => _text;

        // Stores an Image.
        private Image _image;

        // Returns the Image inside _image.
        public Image Image => _image;


        //Below are two constructor methods that are an example of Constructor Overloading

        /// <summary>
        /// Stores data value in text attribute
        /// </summary>
        /// <param name="data">Text data in the form of String</param>
        public NoteEventArgs(String data) 
        {
            this._text = data;
        }

        /// <summary>
        /// Stores data value in image attribute
        /// </summary>
        /// <param name="data">Image data in the form of Image</param>
        public NoteEventArgs(Image data)
        {
            this._image = data;
        }

    }
}
