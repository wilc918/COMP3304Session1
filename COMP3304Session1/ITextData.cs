using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    interface ITextData
    {
        /// <summary>
        /// Change the text from the associated notekey
        /// </summary>
        /// <param name="noteKey">Identify where to store the text</param>
        /// <param name="newText">The text that will replace the current text</param>
        void ChangeText(int noteKey, String newText);

        /// <summary>
        /// Retrieve text from note
        /// </summary>
        /// <param name="noteKey">Identify the text to be retrieved</param>
        /// <returns>The text associated with the key from the dictionary</returns>
        void RetrieveText(int noteKey);

    }
}
