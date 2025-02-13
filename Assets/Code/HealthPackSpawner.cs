using UnityEngine;

public class HealthPackSpawner : MonoBehaviour
{
    public GameObject healthPackPrefab; // Prefab with Renderer
    public HealthPack[] healthPackObjects; // Existing HealthPack objects in the scene

    void Start()
    {
        SpawnHealthPacks();
    }

    void SpawnHealthPacks()
    {
        foreach (HealthPack healthPack in healthPackObjects)
        {
            GameObject visualHealthPack = Instantiate(healthPackPrefab, healthPack.transform.position, Quaternion.identity);

            // Set the spawned prefab as a child of the existing HealthPack object
            visualHealthPack.transform.SetParent(healthPack.transform);
        }
    }
}