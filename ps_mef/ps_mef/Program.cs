using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_mef
{
    using serviceDefinition;
    
    class Program
    {
        static void Main( string[] args )
        {
            DirectoryCatalog catalog = new DirectoryCatalog( "plugins", "*.dll" );

            CompositionContainer container = new CompositionContainer( catalog );

            Car car = new Car();

            container.ComposeParts( car );
            car.Drive();
        }
    }

    class Car
    {
        [Import]
        IEngine m_engine;

        [Import]
        IWheels m_wheels;

        public void Drive()
        {
            m_engine.SpeedUp();
            m_wheels.TurnLeft();
            m_engine.SpeedUp();
            m_wheels.TurnRight();
            m_engine.Brake();
        }
    }
}
