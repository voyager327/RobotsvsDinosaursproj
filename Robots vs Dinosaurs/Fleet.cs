using Robots_vs_Dinosaurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class fleet
    {
        // Member Variables-List of Robots and add Robots to list              
        //Constructors- Create a constructors with multiple parameters 
        public List<Robots> robots;
        Weapon Laser = new Weapon("Laser");
        Weapon Cannon = new Weapon("Cannon");
        Weapon Sword = new Weapon("Sword");
        
        public fleet()
        {
             Robots Maximus = new Robots("Maximus", 120, 100, "Laser", 50);
             Robots Primus = new Robots("Primus", 110, 100, "Cannon", 20);
             Robots Ultima = new Robots("Ultima", 130, 100, "Sword", 25);
            robots.Add(Maximus);
            robots.Add(Primus);
            robots.Add(Ultima);
        }

        public void Run()
        {

        }
    
    }
}    
