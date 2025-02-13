using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;

    void Start()
    {
        LootAngle myLootAngle = new LootAngle();

        void SpawnPotion (int angle, int radius)
       {

            Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
            Vector3 spawnPosition = transform.position + direction * radius;
            Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
       }
        // Potion Spawner
        SpawnPotion(55,5);
        SpawnPotion(85, 15);
        SpawnPotion(135, 25);
        SpawnPotion(140, 20);
    }
}

public class LootAngle
{
    int angle;
    int step;
    LootAngle(int increment)
    {
        step = increment;
        angle = 0;
    }
    int NextAngle()
    {
        int currentAngle = angle;
        angle = Helpers.WrapAngle(angle + step);

        return currentAngle;
    }
}
