using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Dinosaurs
    {
        public string Type;
        public int Health;
        public int Energy;
        public int AttackPower;
        public Dinosaurs(String Type, int Health, int Energy, int AttackPower)
        {
            //Constructos-List of characters consisting Robot
            this.Type = Type;
            this.Health = Health;
            this.Energy = Energy;
            this.AttackPower = AttackPower;

        }
        public void Attack(Robots robo)
        {
            robo.Health -= AttackPower;
        }
    }
}    
        
    

