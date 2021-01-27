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

        private IList<Form> _notesList;

        /// <summary>
        /// CONSTRUCTOR - FishyNotes Object Constructor
        /// </summary>
        public FishyNotes(IList<Form> noteList)
        {
            //Stores the notelist in a local variable.
            _notesList = noteList;
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
            _notesList.Add(new FishyNote());

            //_newNote = new FishyNote();
            for (int i = 0; i < _notesList.Count; i++)
            {
                _notesList[i].Show();

            }

        }
    }
}
