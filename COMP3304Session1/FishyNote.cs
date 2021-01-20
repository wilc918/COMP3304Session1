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
    public partial class FishyNote : Form
    {
        /// <summary>
        /// CONSTRUCTOR - Initialise FishyNote
        /// </summary>
        public FishyNote()
        {
            InitializeComponent();
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
            }
        /// <summary>
        /// METHOD - On click, Shrinks/Expands the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void CollapseButton_Click(object sender, EventArgs e)
            {
            //Attempt at ternary operator. Checks if height is greater than 70, sets height to 69(yes) or 372(no).
            Height = Height > 70 ? Height = 62 : Height = 372;
        }
        /// <summary>
        /// METHOD - On click, if the text is unmodified from default then the text is cleared.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FishyTextBox_Click(object sender, EventArgs e)
        {
            // If FishyTextBox is unmodified then clear the text.
            if (FishyTextBox.Modified == false) {
                FishyTextBox.Text = "";
            }
            
        }

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
        #endregion
        // end of sourced code.
    }
}
