using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAn
{
    public class ShapesAnalyzer
    {
        public bool IsValidShapesFileName(string fileName)
        {
            if (!fileName.EndsWith(".slf"))
                return false;
            return true;
        }
    }
}
