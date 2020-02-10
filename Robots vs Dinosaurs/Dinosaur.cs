using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    public class Dinosaur
    {
        string dinoType;
        string dinoAttackPower;
        int dinoHealth;
        int dinoEnergy;
        int percentageFull;

        public Dinosaur(string dinoType, int dinoHealth, int dinoEnergy, string dinoAttackPower, int percentageFull)
        {
            this.dinoType = dinoType;
            this.dinoHealth = dinoHealth;
            this.dinoEnergy = dinoEnergy;
            this.dinoAttackPower = dinoAttackPower;
            this.percentageFull = percentageFull;
        }

        public void Dino()
        {
            dinoType = "tRex";
        }

        public void Heal()
        {
            dinoHealth -= 10;
        }
        public void Energy()
        {
            dinoEnergy -= 10;
        }
        public void Attack()
        {
            dinoAttackPower += 10;
            }
        public void Lives()
        {
            percentageFull -= 10;
            }
    }
}
    






    
   
  
