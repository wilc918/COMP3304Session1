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
            //Instantiate a FactoryLocator, call it factoryLocator:
            IServiceLocator factoryLocator = new FactoryLocator();

            // Instantiate a Dictionary<int, Form> for the UI to store its notes in, store it as an IDictionary and call it notes:
            IDictionary<int, Form> noteForms = new Dictionary<int, Form>();

            // Instantiate a NoteData to store all note data in, store it as an INoteData and call it noteData:
            //INoteData noteData = new NoteData();
            //Instantiate a factory<INoteData>, call it noteFactory:
            //IFactory<INoteData> noteFactory = factoryLocator.Get<INoteData>() as IFactory<INoteData>;
            // Instantiate a noteData using noteFactory:
            //INoteData noteData = noteFactory.Create<NoteData>();
            //Do it together in one line.
            INoteData noteData = (factoryLocator.Get<INoteData>() as IFactory<INoteData>).Create<NoteData>();

            // Get a reference to a Form factory, call it formFactory:
            IFactory<Form> formFactory = factoryLocator.Get<Form>() as IFactory<Form>;

            //Create List of type Form according to interface IList<> and stored within noteList local variable.
            //IList<Form> noteList = new List<Form>();
            //Runs a new FishyNotes Form that takes noteList as a parameter
            Application.Run(new FishyNotes(formFactory, noteForms, noteData));
        }
        

    }
}
