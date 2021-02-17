using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{


    /// <summary>
    /// Class - Describes the methods and attributes of the FishyNotes Form
    /// 
    /// Author  (Calum Wilkinson)
    /// Version (27/01/2020)
    /// </summary>
    public partial class FishyNotes : Form
    {
        //private IList<Form> _noteForms;

        // DECLARE a IDictionary to store new note Forms in, call it _noteForms:
        private IDictionary<int, Form> _noteForms;

        // DECLARE an INoteData to store all note data in, call it _noteData:
        private INoteData _noteData;

        // DECLARE an ITextData to access note text in, call it _noteText:
        private ITextData _noteText;

        // DECLARE an IImageData to access note images, call it _noteImages:
        private IImageData _noteImages;

        // Declare an int to store the value for the next noteKey, call it _nextNoteKey, set it to 0:
        int _nextNoteKey = 0;



        /// <summary>
        /// CONSTRUCTOR - FishyNotes Object Constructor
        /// </summary>
        /// <param name="noteList"></param>
        public FishyNotes(IDictionary<int, Form> noteContainer, INoteData noteData)
        {
            //Stores the notelist in a local variable.
            //_noteForms = noteList;
            InitializeComponent();

            //Instantiate _noteForms:
            _noteForms = noteContainer;

            // Instantiate _noteData:
            _noteData = noteData;

            // Initialise _noteText:
            _noteText = _noteData as ITextData;

            // Initialise _noteImages
            _noteImages = _noteData as IImageData;

        }
        
        public void RemoveNote(int noteKey) 
        {
            // Delete note from _noteData:
            _noteForms.Remove(noteKey);

            // Delete note from _noteForms:
            _noteForms.Remove(noteKey);
        }

        /// <summary>
        /// Callback for when the AddItem button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNote_Click(object sender, EventArgs e)
        {
            // Add new note entry into _noteData, with empty text:
            _noteData.AddItem(_nextNoteKey);

            // Add new FishyNote and assign its noteKey:
            FishyNote note = new FishyNote(_nextNoteKey, _noteImages.RetrieveImage(_nextNoteKey), _noteText.ChangeText, _noteText.RetrieveText, this.RemoveNote);

            _noteForms.Add(_nextNoteKey, note);

            //Show the new note (also increment _nextNoteKey afterwards):
            _noteForms[_nextNoteKey].Show();
            _nextNoteKey++;
        }

       
        /// <summary>
        /// METHOD - Instantiating a new FishyNote Form Object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       /* private void MoreFishButton_Click(object sender, EventArgs e)
        {
            Form newNote = new FishyNote(_nextNoteKey);
            _noteForms.Add(newNote);
            newNote.Show();

        }*/
    }
}
