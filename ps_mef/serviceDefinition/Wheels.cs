using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceDefinition
{
    [InheritedExport]
    public interface IWheels
    {
        void TurnLeft();
        void TurnRight();
    }
}
