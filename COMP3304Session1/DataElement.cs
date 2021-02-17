using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    class DataElement : IDataElement
    {
        // DECLARE a String to store text in, call it _text:
        private String _text;

        // DECLARE a Image to store an images in, call it _image:
        private Image _image;

        #region Implementation of IDataElement
        public void Initialise(String text, Image image) 
        {
            // Assign parameters to data:
            _text = text;
            _image = image;
        }

        /// <summary>
        /// Retrieve the image, scaled to a specific size.
        /// </summary>
        /// <returns>The image</returns>
        public Image RetrieveImage() 
        {
            // SCALE _image and fire event:
            return _image;
        }

        /// <summary>
        /// Change text in the specified note.
        /// </summary>
        /// <param name="newText">The new text to be stored in the element</param>
        public void ChangeText(String newText)
        {
            // UPDATE text for the note with id noteKey:
            _text = newText;
        }
        /// <summary>
        /// Retrieve text.
        /// </summary>
        /// <returns>The note text</returns>
        public String RetrieveText()
        {
            // RETURN text event:
            return _text;
        }
        #endregion

        #region Implementation of IDisposable
        public void Dispose()
        {
            _image.Dispose();
        }
        #endregion

    }
}
