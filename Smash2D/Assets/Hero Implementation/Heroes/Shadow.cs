using System;

namespace Hero_Implementation.Heroes
{
    public class Shadow : Assassin
    {

        public Shadow(float movSpd, float jump)
        {
            movingSpeed = movSpd;
            jumpValue = jump;
        }

        public float getMovingSpeed()
        {
            return movingSpeed;
        }
        public override void Move()
        {
            
        }
        
        public override void Ability1()
        {
            
        }

        public override void Ability2()
        {
            
        }

        public override void Ability3()
        {
            
        }
    }
}
