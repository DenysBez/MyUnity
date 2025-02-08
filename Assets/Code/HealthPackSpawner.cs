using UnityEngine;

public class HealthPackSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject healthPackPrefab;

    void Start()
    {
        SpawnHealthPacks();
    }

    void SpawnHealthPacks()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            Instantiate(healthPackPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}