using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
    using serviceDefinition;

    class Engine : IEngine
    {
        public void Brake()
        {
            System.Console.WriteLine( "Ferrari: Braking." );
        }

        public void SpeedUp()
        {
            System.Console.WriteLine( "Ferrari: Speeding Up." );
        }
    }
}
