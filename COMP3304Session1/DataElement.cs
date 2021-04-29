using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    /// <summary>
    /// Class for enacting loading and transformation of data such as images and strings
    /// </summary>
    class DataElement : IDataElement, IInternalEventPublisher, IDisposable
    {
        // DECLARE a String to store text in, call it _text:
        private String _text;

        // DECLARE a Image to store an images in, call it _image:
        private Image _image;

        // DECLARE an event for storing note event handlers, call it _noteEvent;
        private event EventHandler<NoteEventArgs> _noteEvent;

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
        public void RetrieveImage() 
        {
            // SCALE _image and fire event:
            //return _image;
            OnNewImageInput(_image);
        }

        /// <summary>
        /// Change text in the specified note.
        /// </summary>
        /// <param name="newText">The new text to be stored in the element</param>
        public void ChangeText(String newText)
        {
            // UPDATE text for the note with id noteKey:
            _text = newText;

            // RETURN text event:
            OnNewTextInput(_text);

        }
        /// <summary>
        /// Retrieve text.
        /// </summary>
        /// <returns>The note text</returns>
        public void RetrieveText()
        {
            // RETURN text event:
            //return _text;
            OnNewTextInput(_text);

        }
        #endregion

        #region Implementation of IInternalEventPublisher

        /// <summary>
        /// Subscribe a listener to note events
        /// </summary>
        /// <param name="listener">Reference to the listener method</param>
        public void Subscribe(EventHandler<NoteEventArgs> listener) 
        {
            _noteEvent += listener;
        }

        /// <summary>
        /// Unsubscribe a listener from note events
        /// </summary>
        /// <param name="listener">Reference to the listener method</param>
        public void Unsubscribe(EventHandler<NoteEventArgs> listener) 
        {
            _noteEvent -= listener;
        }

        #endregion

        #region Implementation of IDisposable
        public void Dispose()
        {
            _image.Dispose();
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Called when a new text input is recieved
        /// </summary>
        /// <param name="data">The text</param>
        private void OnNewTextInput(String data) 
        {
            NoteEventArgs textArgs = new NoteEventArgs(data);
            _noteEvent(this, textArgs);
        }

        private void OnNewImageInput(Image data) 
        {
            NoteEventArgs imageArgs = new NoteEventArgs(data);
            _noteEvent(this, imageArgs);
        }


        #endregion

    }
}
