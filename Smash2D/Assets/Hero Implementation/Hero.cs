using System;

namespace Hero_Implementation
{
    public abstract class Hero
    {
        protected float jumpValue,
            movingSpeed,
            healthPoints,
            attackPower;
        
        public abstract void Move();
        public abstract void Ability1();
        public abstract void Ability2();
        public abstract void Ability3();
    }
}