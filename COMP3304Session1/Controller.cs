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
            // Instantiate a Dictionary<int, Form> for the UI to store its notes in, store it as an IDictionary and call it notes:
            IDictionary<int, Form> noteForms = new Dictionary<int, Form>();

            // Instantiate a NoteData to store all note data in, store it as an INoteData and call it noteData:
            INoteData noteData = new NoteData();

            //Create List of type Form according to interface IList<> and stored within noteList local variable.
            //IList<Form> noteList = new List<Form>();
            //Runs a new FishyNotes Form that takes noteList as a parameter
            Application.Run(new FishyNotes(noteForms, noteData));
        }
        

    }
}
