using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    //member variable

    class Battlefield
    {

        int roboScore;
        int dinoScore;
        int battleRounds;
        Herd herd = new Herd();
        Fleet fleet = new Fleet();

        public void RunGame()
        {
            

            bool gameRunning = true;
            while (gameRunning == true)
            {
                //Console.WriteLine("dinoScore");
                for (int i = 0; battleRounds < 4; i++)
                {
                    battleRounds++;
                    robotsAttack();
                    
                    Console.WriteLine("Robots Attacked Dinosaurs..");
                    Console.ReadLine();
                    
                    dinosaursAttack();
                    
                    Console.WriteLine("Dinosaurs Attacked Robots..");
                    Console.ReadLine(); 

                    Console.WriteLine("Round: " + battleRounds);
                    if (battleRounds > 3)
                    {
                        gameRunning = false;
                        determineWinner(); 
                    } 
                }
            }
        }  
        
        public void robotsAttack()
        {
            for (int i = 0; i < herd.dinosaurs.Count; i++)
            {
                herd.dinosaurs[i].dinoHealth -= fleet.cyborgFleet[i].roboPowerLevel;
                roboScore++;
            }
        }

        public void dinosaursAttack()
        {
            for (int i = 0; i < fleet.cyborgFleet.Count; i++)
            {
                fleet.cyborgFleet[i].roboHealth -= herd.dinosaurs[i].dinoEnergy;
                dinoScore++; 
            }
        }

        public void determineWinner()
        {
            Console.WriteLine("Robots Scored: " + roboScore + " Dinosaurs Scored: " + dinoScore);
            Console.WriteLine("thank you for playing");
            Console.ReadLine();
        }
    }
}






