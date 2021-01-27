using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{
    class Controller
    {
       /// <summary>
       /// CONSTRUCTOR - runs application FishyNotes.
       /// Public :(
       /// </summary>
        public Controller() {
            IList<Form> noteList = new List<Form>();
            //Runs a new FishyNotes Form that takes noteList as a parameter
            Application.Run(new FishyNotes(noteList));
        }
        

    }
}
