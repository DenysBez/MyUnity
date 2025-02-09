using UnityEngine;

namespace HomeWork1
{
    public class EmptyGameObject : MonoBehaviour
    {
        private void Start()
        {
            int health = 100;
            float speed = 5.5f;
            bool isAlive = true;

            Debug.Log($"Health: {health} (int)");
            Debug.Log($"Speed: {speed} (float)");
            Debug.Log($"Is Alive: {isAlive} (bool)");
        
            DamageSystem damageSystem = new DamageSystem(50, 1.2f);
            float damage = damageSystem.CalculateDamage();

            Debug.Log($"Total Damage Calculated: {damage}");
        }
    }
}