using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Herd 
    {
        // Member Variables-List of Dinosaurs and add it to list              
        //Constructors- Create a constructors with multiple parameters 
        public List<Dinosaurs> dino;
        Dinosaurs Velociraptor = new Dinosaurs("Velociraptor", 100, 200, 25);
        Dinosaurs Coelophysis = new Dinosaurs("Coelophysis", 100, 150, 50);
        Dinosaurs Ankylosaurus = new Dinosaurs("Ankylosaurus", 100, 180, 20);
        //Velociraptor's High Striking Metal Piercing Claws AttackPower is equal to 25 points
        //Coelophysis's Agile and Boasted Blade-Like Cutting Teeth AttackPower is equal to 50 points
        //Ankylosaurus's Armored Swinging Tail Attack Power is equal to 20 points
        public Herd()
        {
            dino.Add(Velociraptor);
            dino.Add(Coelophysis);
            dino.Add(Ankylosaurus);
        }
        public void Run()
        {

        }               
 
    }
}
