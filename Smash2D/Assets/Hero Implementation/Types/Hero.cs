namespace Hero_Implementation.Types
{
    public abstract class Hero
    {
        protected float jumpValue,
            movingSpeed,
            healthPoints,
            attackPower;
        public abstract void Ability1();
        public abstract void Ability2();
        public abstract void Ability3();
    }
}