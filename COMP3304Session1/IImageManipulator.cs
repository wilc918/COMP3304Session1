using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304Session1
{
    public interface IImageManipulator
    {
        //
        Image Scale(Image image, Size size);
    }
}
