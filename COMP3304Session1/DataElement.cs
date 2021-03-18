using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    class DataElement : IDataElement, IInternalPublisher
    {
        // DECLARE a String to store text in, call it _text:
        private String _text;

        // DECLARE a Image to store an images in, call it _image:
        private Image _image;

        private event EventHandler<NoteEventArgs> newData;

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
            OnDataChanged(_image);
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

            OnDataChanged(_text);
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

        #region IMPLEMENTATION of IInternalEventPublisher

        /// <summary>
        /// Subscribe a listener to note events
        /// </summary>
        /// <param name="listener">Reference to the changes given</param>
        public void Subscribe(EventHandler<NoteEventArgs> listener)
        {
            //Add data listener to our eventHandler
            newData += listener;
        }

        public void Unsubscribe(EventHandler<NoteEventArgs> listener)
        {
            //Remove data listener from our eventHandler
            newData -= listener;
        }

        #endregion

        #region Implementation of IDisposable
        public void Dispose()
        {
            _image.Dispose();
        }
        #endregion

        #region private methods
        /// <summary>
        /// Call when data changes, create new noteEventArgs that store the data
        /// </summary>
        /// <param name="data">Image that changed</param>
        private void OnDataChanged(Image data)
        {
            //Instantiate new noteEventArgs
            NoteEventArgs args = new NoteEventArgs(data);
            //Store the events inside the eventHandler according to key
            newData(this, args);
        }

        /// <summary>
        /// Call when data changes, create new noteEventArgs that store the data
        /// </summary>
        /// <param name="data">Text that changed</param>
        private void OnDataChanged(String data)
        {
            //Instantiate new noteEventArgs
            NoteEventArgs args = new NoteEventArgs(data);
            //Store the events inside the eventHandler according to key
            newData(this, args);
        }


        #endregion

    }
}
