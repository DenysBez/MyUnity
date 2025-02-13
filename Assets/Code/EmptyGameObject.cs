using UnityEngine;

public class EmptyGameObject : MonoBehaviour
{
    void Start()
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

// Damage calculation class
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
