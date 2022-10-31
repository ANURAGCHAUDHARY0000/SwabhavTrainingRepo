using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFolderApp.Model
{
    internal interface IStorageType
    {
         void Display(int depth = 0);
    }
}
