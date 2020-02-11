using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Fleet
    {
        public List<Robots> cyborgFleet;

       public Fleet()
        {
            cyborgFleet = new List<Robots>() { new Robots("Terminator", 100, 100, 100, "Bazooka", 100), new Robots("Cyborg", 100, 100, 100, "Ray-Gun", 100), new Robots("Android", 100, 100, 100, "Sword", 100)}; 
        }
    }
}
