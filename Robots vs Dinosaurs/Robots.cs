using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Robots
    {
        //Member Variables- 
        public string Name;
        public int PowerLevel;
        public int Health;
        public string Weapon;
        public int AttackPower;
     

        public Robots(string Name, int Health, int PowerLevel, string weapon, int AttackPower)
        //Constructors- List of Characters Consisting Robot 
        {
            this.Name = Name;
            this.Health = Health;                
            this.PowerLevel = PowerLevel;
            this.Weapon = weapon;
            this.AttackPower = AttackPower;

        }
        public void Attack(Dinosaurs dino)
        {
            dino.Health -= AttackPower;
        }
        
    }       
 
}
        
       
     


         
          

          
        



        

    
   

    



      
        
    

