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
            Height = Height > 70 ? Height = 69 : Height = 372;
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
    }
}
