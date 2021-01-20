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
    /// Version (20/01/2020)
    /// </summary>
    public partial class FishyNotes : Form
    {

        private Form _newNote;

        /// <summary>
        /// CONSTRUCTOR - FishyNotes Object Constructor
        /// </summary>
        public FishyNotes()
        {
            InitializeComponent();
        }

        private void FishyNotes_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// METHOD - Instantiating a new FishyNote Form Object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoreFishButton_Click(object sender, EventArgs e)
        {
            // Instantiate and then show a new FishyNote Object within the _newNote attribute, if none exists.
            if (_newNote == null) {
                _newNote = new FishyNote();
                _newNote.Show();
            }

        }
    }
}
