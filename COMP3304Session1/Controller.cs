using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{
    /// <summary>
    /// Class - Starts the FishyNotes application and injects it with its dependencies (the list).
    /// 
    /// Author  (Calum Wilkinson)
    /// Version (27/01/2020)
    /// </summary>
    class Controller
    {
       /// <summary>
       /// CONSTRUCTOR - runs application FishyNotes.
       /// Public :(
       /// </summary>
        public Controller() {
            //Create List of type Form according to interface IList<> and stored within noteList local variable.
            IList<Form> noteList = new List<Form>();
            //Runs a new FishyNotes Form that takes noteList as a parameter
            Application.Run(new FishyNotes(noteList));
        }
        

    }
}
