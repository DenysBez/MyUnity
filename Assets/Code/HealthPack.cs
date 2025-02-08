using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int healthCounter = 20;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Health pack collected! HP increased by " + healthCounter);
            Destroy(gameObject);
        }
    }
}