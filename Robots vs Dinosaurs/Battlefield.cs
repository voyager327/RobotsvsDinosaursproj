using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Battlefield
    {
        fleet robotFleet = new fleet();
        Herd dinoHerd = new Herd();
        public int sides;
        public int rematch;
        public double PickFighter(int sides)
        {
            int rematch = robotFleet.fleet(1, sides)
        // Player will Pick Fighter for the Battle and continue to rematch until Fighter's Health Score is Zero
            Console.WriteLine("Select RoboFighter.\n1) Maximus\n2 Primus\n3) Ultima");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    robotFleet.robots[0].Attack(dinoHerd.dino[0]);
                    break;
                case 2:
                    robotFleet.robots[1].Attack(dinoHerd.dino[1]);
                    break;
                case 3:
                    robotFleet.robots[2].Attack(dinoHerd.dino[2]);
                    break;
            }
            return rematch;
        }
        //AttackPower wil be used as variables to determine on who will win the fight
        public double FinalKill(string Maximus, string Velociraptor)
        {
            if (Maximus.AttackPower > Velociraptor.AttackPower)
            { 
                Velociraptor.Health--;


            }   

        }

        public double PickFighter(Herd herd)
            //Pick Fighter to fight against fleet  
        {
            Console.WriteLine("Please Select DinoFighter.\n1) Velociraptor\n2) Coelophysis\n3) Ankylosaurus");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
               case 1:
                   dinoHerd.dino[0].Attack(robotFleet.robots[0]);
                   break;
               case 2:
                   dinoHerd.dino[1].Attack(robotFleet.robots[1]);
                   break;
                case 3:
                    dinoHerd.dino[2].Attack(robotFleet.robots[2]);
                    break;

            }
            return 0;
            {
               
            }
 
        }
    }
}
