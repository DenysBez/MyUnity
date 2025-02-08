using UnityEngine;

namespace HomeWork1
{
    public class DamageSystem
    {
        private int baseDamage;
        private float multiplier;

        public DamageSystem(int baseDamage, float multiplier)
        {
            this.baseDamage = baseDamage;
            this.multiplier = multiplier;
        }

        public float CalculateDamage()
        {
            float totalDamage = baseDamage * multiplier;
            Debug.Log($"Calculating Damage: {baseDamage} * {multiplier} = {totalDamage}");
            return totalDamage;
        }
    }
}