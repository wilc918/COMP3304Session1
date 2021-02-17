using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    public interface IDataElement
    {
        /// <summary>
        /// Initialise this data element with rqd data
        /// </summary>
        /// <param name="text">Initial text</param>
        /// <param name="image">The image</param>
        void Initialise(String text, Image image);

        /// <summary>
        /// Retrieve the image.
        /// </summary>
        /// <returns>The image</returns>
        Image RetrieveImage();

        /// <summary>
        /// Change text in the specified note.
        /// </summary>
        /// <param name="newText">The new text to be stored in the element</param>
        void ChangeText(String newText);

        /// <summary>
        /// Retrieve Text.
        /// </summary>
        /// <returns>The note text</returns>
        String RetrieveText();
    }
}
