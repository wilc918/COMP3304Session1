using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    public class NoteData : INoteData, ITextData, IImageData
    {
        // DECLARE a string to store path for images on close button, call it _imagePath:
        private const string _imagePath = "..\\..\\FishAssets\\";

        // DECLARE a List<String> to store a list of path+filename for all available image assets, call it _imageName:
        private IList<String> _imageNames;

        // DECLARE an int to act as a circular counter index into _imageNames:
        private int _cCounter = 0;

        // DECLARE a Dictionary<int,DataElement> to store all data in, call it _data:
        private IDictionary<int, DataElement> _data;



        /// <summary>
        /// Constructor for objects of type NoteData.
        /// </summary>
        public NoteData()
        {
            // Instantiate _data:
            _data = new Dictionary<int, DataElement>();

            //Instantiate and populate _imageNames:
            _imageNames = new List<String>(Directory.GetFiles(_imagePath));
        }


        #region IMLPEMENTATION of INoteData
        /// <summary>
        /// Add a new note
        /// </summary>
        /// <param name="key">unique key of new note</param>
        public void AddItem(int key)
        {
            // Create new DataElement, call it element:
            DataElement element = new DataElement();

            // Store empty text and next note image into element:
            //element.Initialise("", Bitmap.FromFile(Path.GetFullPath(_imageNames[CircularCounter(_imageNames.Count)])));
            element.Initialise("",Bitmap.FromFile(Path.GetFullPath(_imageNames[CircularCounter(_imageNames.Count)])));

            // Add element to _data with given key:
            _data.Add(key, element);

        }
        /// <summary>
        /// Remove a note
        /// </summary>
        /// <param name="key">the identifier of the note to be removed</param>
        public void RemoveItem(int key)
        {
            // Remove element from _data:
            _data[key].Dispose();
            _data.Remove(key);
        }
        #endregion

        #region IMPLEMENTATION OF ITextData
        /// <summary>
        /// Change text in the specified note
        /// </summary>
        /// <param name="noteKey">The identifier for note to be changed</param>
        /// <param name="newText">The new text to be stored in the note</param>
        public void ChangeText(int noteKey, String newText) 
        {
            // UPDATE text for the note with id noteKey:
            _data[noteKey].ChangeText(newText);
        }

        public String RetrieveText(int noteKey)
        {
            // RETURN text for the note with id notekey:
            return _data[noteKey].RetrieveText();
        }

        #endregion

        #region IMPLEMENTATION OF IImageData
        public Image RetrieveImage(int noteKey)
        {
            return _data[noteKey].RetrieveImage();
        }
        #endregion

        #region IMPLEMENTATION of IEventPublisher

        /// <summary>
        /// Subscribe a listener to note events
        /// </summary>
        /// <param name="key">Key to the note</param>
        /// <param name="listener">Reference to the changes given</param>
        public void Subscribe(int key, EventHandler<NoteEventArgs> listener)
        {
            //Cast the dataElement as IInternalPublisher so the Subscribe method can be called
            //the goal is to keep the actual operations private via encapsulation
           (_data[key] as IInternalPublisher).Subscribe(listener);
        }

        public void Unsubscribe(int key, EventHandler<NoteEventArgs> listener)
        {
            //Cast the dataElement as IInternalPublisher so the Unsubscribe method can be called
            (_data[key] as IInternalPublisher).Unsubscribe(listener);
        }

        #endregion


        #region Private Methods

        /// <summary>
        /// Method to control image file (as a Blob) that is instantiated as part of a note.
        /// </summary>
        /// <param name="maxValue">The total number of image files in use</param>
        /// <returns></returns>
        private int CircularCounter(int maxValue)
        {
            _cCounter++;
            if (_cCounter == maxValue)
            {
                _cCounter = 0;
            }
            return _cCounter;
        }


        #endregion

    }
}
