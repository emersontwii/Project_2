using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {   
       void SpawnPotion (int angle, int radius)
       {

            Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
            Vector3 spawnPosition = transform.position + direction * radius;
            Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
       }
        // Potion Spawner
        SpawnPotion(55,5)   ;
        SpawnPotion(85, 15);
        SpawnPotion(135, 25);
        SpawnPotion(140, 20);
    }
}

