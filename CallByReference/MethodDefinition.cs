using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByReference
{
    public class MethodDefinition
    {
        public int UpdateNumberTo100(ref int numberEntered)
        {
            return numberEntered = 100;
        }
    }
}
