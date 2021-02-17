using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    interface IImageData
    {
        /// <summary>
        /// Retrieve an image to be associated with the note
        /// </summary>
        /// <param name="noteKey">Key for the dictionary to identify which note to choose the image for</param>
        /// <returns>The image that is paired with that key</returns>
        Image RetrieveImage(int noteKey);
    }
}
