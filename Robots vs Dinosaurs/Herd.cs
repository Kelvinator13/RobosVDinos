using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Herd
    {
        public List<Dinosaur> dinosaurs; 
        public Herd()
        {
           dinosaurs = new List<Dinosaur>() { new Dinosaur( "tRex", 100, 100, "tail", 100), new Dinosaur("Godzilla", 100, 100, "teeth", 100), new Dinosaur("King Kong", 100, 100, "claws", 100)};
        }            
    }
}
