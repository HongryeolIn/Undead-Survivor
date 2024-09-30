using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] SpawnPoint;

    float timer;
    float spawnRate = 0.2f;

    private void Awake()
    {
        SpawnPoint = GetComponentsInChildren<Transform>();
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= spawnRate)
        {
            Spawn();
            timer = 0f;
        }
    }
    
    void Spawn()
    {
        GameObject enemy = GameManager.instance.Pool.Get(Random.Range(0,2));
        enemy.transform.position = SpawnPoint[Random.Range(1,SpawnPoint.Length)].position;
    }
}
