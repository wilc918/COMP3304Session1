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
    ///Class - Describes the methods and attributes of the FishyNote Form that allow for Movement, Collapsing, Deletion and Text modification.
    /// 
    /// Author  (Calum Wilkinson)
    /// Version (27/01/2020)
    /// </summary>
    public partial class FishyNote : Form, IEventListener
    {

        // DECLARE a Size for the size of the sticky note when 'open', call it _openSize:
        private Size _openSize = new System.Drawing.Size(560, 530);

        // DECLARE a Size for the size of the sticky note when 'closed', call it _closedSize:
        private Size _closedSize = new System.Drawing.Size(152,107);

        //DECLARE a boolean to flag whether the note is 'open' or 'closed', make it true when 'open' and call it _openFlag:
        private bool _openFlag = true;

        //DECLARE a String to give persistence to the text in the text box, call it _text:
        private String _text;

        // Declare an int _id, it stores the ID given to the fishynote
        private int _id = 0;

        // DECLARE a ReplaceTextDelegate for all delegates to be called when note text has changed, call it _changeTextCallback:
        private ReplaceTextDelegate _changeTextCallback;

        // DECLARE a RetrieveTextDelegate for the delegate to be called to retrieve note text, call it _getTextCallback:
        private RetrieveTextDelegate _getTextCallback;

        // DECLARE a SelectItemDelegate for the delegate to be called when the note is to be deleted, call it _deleteThis:
        private SelectItemDelegate _deleteThis;


        /// <summary>
        /// CONSTRUCTOR - Initialise FishyNote
        /// </summary>
        public FishyNote(int id, RetrieveImageDelegate retrieveImage, ReplaceTextDelegate replaceText, RetrieveTextDelegate retrieveText, SelectItemDelegate deleteMe)
        {
            InitializeComponent();

            //SET _id; remember to put it in the parameter
            _id = id;

            // SET image
            //this.CollapseButton.Image = image;
            //retrieveImage(_id);
 
            // SET _changeTextCallback to replaceText:
            _changeTextCallback += replaceText;

            // SET _getTextCallback to retrieveText:
            _getTextCallback += retrieveText;

            // SET _deleteThis to deleteMe:
            _deleteThis += deleteMe;
        }

        public void Initialise(int id, RetrieveImageDelegate retrieveImage)
        {

            //SET _id; remember to put it in the parameter
            _id = id;

            // SET image
            //this.CollapseButton.Image = image;
            retrieveImage(_id);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// METHOD - On click, Deletes the FishyNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void FishyDeleteButton_Click(object sender, EventArgs e)
            {
                // Disposes of this particular FishyNote Instance.
                this.Dispose();
                this._deleteThis(_id);
            }
        /// <summary>
        /// METHOD - On click, Shrinks/Expands the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void CollapseButton_Click(object sender, EventArgs e)
            {
            // If window is open, close it:
            if (_openFlag)
            {
                //Set its size to _closedSize:
                this.ClientSize = _closedSize;

                // Reset the _openFlag:
                this._openFlag = false;
            }

            // If the window is closed open it:
            else
            {

                //Set it s size to _openSize:
                this.ClientSize = _openSize;

                //Reset the _openFlag:
                this._openFlag = true;
            }


            }
        /// <summary>
        /// METHOD - On click, if the text is unmodified from default then the text is cleared.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FishyTextBox_Click(object sender, EventArgs e)
        {
            // If FishyTextBox is unmodified then clear the text.
           /* if (FishyTextBox.Modified == false) {
                FishyTextBox.Text = "";
            }*/
           _getTextCallback(_id);
        }

        private void NoteTextBox_Changed(object sender, EventArgs e)
        {
            // STORE text in box into _text:
            _text = this.FishyTextBox.Text;

            // Call _changeTextCallback:
            _changeTextCallback(_id, this.FishyTextBox.Text);
        }

        #region Implementation of IEventListener
        public void OnNewInput(object source, NoteEventArgs args) 
        {
            //Check for new image data:
            if (args.image != null) 
            {
                // load it into CollapseButton.Image:
                this.CollapseButton.Image = args.image;
            }

            //Check for new text data:
            if (args.text != null) 
            {
                // load it into FishyTextBox.Text:
                this.FishyTextBox.Text = args.text;
            }


        }
        #endregion

        /// <summary>
        /// All code below was sourced from COMP3304 - Advanced Object Oriented Programming led by Dr Marc Price.
        /// </summary>

        #region Code Snippet: makes this borderless window movable
        // Modified from https://stackoverflow.com/a/24561946 and attributed to user jay_t55

        // DECLARE a boolean that is set to true when a mouse down event is detected, call it _mouseDown:
        private bool _mouseDown = false;

        // DECLARE a Point object to store the last location of the window origin (ie memory), call it _lastLocation:
        private Point _lastLocation;

        // Mouse down event handler
        private void FishyNote_MouseDown(object sender, MouseEventArgs e)
        {
            // SET _mouseDown true:
            _mouseDown = true;

            // STORE current location to _lastLocation:
            _lastLocation = e.Location;
        }

        // Mouse move event handler
        private void FishyNote_MouseMove(object sender, MouseEventArgs e)
        {
            // Only act if mouse button is down...
            if (_mouseDown)
            {
                // SET new location according to mouse movement from _lastLocation:
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);

                // UPDATE this window:
                this.Update();
            }
        }

        // Mouse up event handler
        private void FishyNote_MouseUp(object sender, MouseEventArgs e)
        {
            // RESET _mouseDown to false:
            _mouseDown = false;
        }

        private void FishyNote_Load(object sender, EventArgs e)
        {

        }
        #endregion
        // end of sourced code.
    }
}
