namespace Hero_Implementation.Types
{
    public class Stamina
    {
        private int staminaValue,
            staminaValueRegenRate;

        public int StaminaValue
        {
            get => staminaValue;
            set => staminaValue = value;
        }
        public int StaminaValueRegenRate
        {
            get => staminaValueRegenRate;
            set => staminaValueRegenRate = value;
        }

        public void ReduceStamina(int staminaToBeReduced)
        {
            staminaValue -= staminaToBeReduced;
        }

        public void RegenStamina()
        {
            staminaValue += staminaValueRegenRate;
        }
    }
}