using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
    using serviceDefinition;

    class Wheels : IWheels
    {
        public void TurnLeft()
        {
            System.Console.WriteLine( "Ferrari: Turning left.") ;
        }

        public void TurnRight()
        {
            System.Console.WriteLine( "Ferrari: Turning right." );
        }
    }
}
