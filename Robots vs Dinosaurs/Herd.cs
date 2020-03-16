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
        Dinosaurs Velociraptor = new Dinosaurs("Velociraptor", 100, 200, "High Speed Striking Metal Piercing Claws");
        Dinosaurs Coelophysis  = new Dinosaurs("Coelophysis", 100, 150, "Agile and Boasted Blade-Like Cutting Teeth");
        Dinosaurs Ankylosaurus = new Dinosaurs("Ankylosaurus", 100, 180, "Armored Swinging Tail");

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
