using System;

namespace Sandbox1
{
    class Warrior : BaseRole  //Warrior inherits from BaseRole but overrides the Attack method for warrior 
    {
        public Warrior()
        {
            
        }
        public override void Attack()
        {
            Console.WriteLine("Warrior big hit logic");
        }
    }
}
