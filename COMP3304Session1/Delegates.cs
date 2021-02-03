using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    /// <summary>
    /// Declare a delegate for replacing stored text, call it ReplaceTextDelegate
    /// </summary>
    /// <param name="noteKey">Note Identifier</param> 
    /// <param name="newText">Note text</param>
    public delegate void ReplaceTextDelegate(int noteKey, String newText);

    /// <summary>
    /// Declare a delegate for retrieving stored text, call it RetrieveTest
    /// </summary>
    /// <param name="noteKey">Note Identifier</param>
    /// <returns>Associated note text</returns>
    public delegate String RetrieveTextDelegate(int noteKey);

    /// <summary>
    /// Declare a delegate for selecting an item, call it SelectItem
    /// </summary>
    /// <param name="key">Identifier of item to be selected</param>
    public delegate void SelectItemDelegate(int key);

}
