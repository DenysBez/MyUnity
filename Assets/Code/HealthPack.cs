using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int healthCounter = 20;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CapsulePlayerIdentifier>() != null)
        {
            Debug.Log("Health pack collected! HP increased by " + healthCounter);
            Destroy(gameObject);
        }
    }
}