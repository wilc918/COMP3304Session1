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
        private IList<Form> _noteForms;

        // DECLARE a IDictionary to store new note Forms in, call it _noteForms:
       // private IDictionary<int, Form> _noteForms;

        // Declare an int to store the value for the next noteKey, call it _nextNoteKey, set it to 0:
        int _nextNoteKey = 0;



        /// <summary>
        /// CONSTRUCTOR - FishyNotes Object Constructor
        /// </summary>
        /// <param name="noteList"></param>
        public FishyNotes(IList<Form> noteList)
        {
            //Stores the notelist in a local variable.
            _noteForms = noteList;
            InitializeComponent();
        }
        /*
        public void RemoveNote(int noteKey) 
        {
            _noteForms.Remove(noteKey);
        }
        */
        /// <summary>
        /// METHOD - Instantiating a new FishyNote Form Object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoreFishButton_Click(object sender, EventArgs e)
        {
            Form newNote = new FishyNote(_nextNoteKey);
            _noteForms.Add(newNote);
            newNote.Show();

        }
    }
}
