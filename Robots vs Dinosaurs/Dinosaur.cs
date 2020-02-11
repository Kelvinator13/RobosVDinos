using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Dinosaur
    {
        public string dinoType;
        public string dinoAttackPower;
        public int dinoHealth;
        public int dinoEnergy;
        public int percentageFull;

        public Dinosaur(string dinoType, int dinoHealth, int dinoEnergy, string dinoAttackPower, int percentageFull)
        {
            this.dinoType = dinoType;
            this.dinoHealth = dinoHealth;
            this.dinoEnergy = dinoEnergy;
            this.dinoAttackPower = dinoAttackPower;
            this.percentageFull = percentageFull;
        }
    }
}
    






    
   
  
