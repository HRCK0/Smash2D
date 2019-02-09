using System;

namespace Hero_Implementation.Heroes
{
    public class Shadow : Assassin
    {

        public Shadow(float movSpd, float jump, float hp, float attack)
        {
            movingSpeed = movSpd;
            jumpValue = jump;
            healthPoints = hp;
            attackPower = attack;
        }

        public float getMovingSpeed()
        {
            return movingSpeed;
        }

        public float getJumpValue()
        {
            return jumpValue;
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
