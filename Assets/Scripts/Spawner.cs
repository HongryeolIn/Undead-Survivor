using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] SpawnPoint;
    public SpawnData[] SpawnData;

    int level;
    float timer;
    float spawnRate = 0.2f;

    private void Awake()
    {
        SpawnPoint = GetComponentsInChildren<Transform>();
    }
    void Update()
    {
        timer += Time.deltaTime;
        level = Mathf.FloorToInt(GameManager.instance.GameTime / 10f);
        if(timer >= SpawnData[level].SpawnTime)
        {
            Spawn();
            timer = 0f;
        }
    }
    
    void Spawn()
    {
        GameObject enemy = GameManager.instance.Pool.Get(0);
        enemy.transform.position = SpawnPoint[Random.Range(1,SpawnPoint.Length)].position;
        enemy.GetComponent<Enemy>().Init(SpawnData[level]);
    }
}

[System.Serializable]
    public class SpawnData
{
    public float SpawnTime;
    public int SpriteType;
    public int Health;
    public float Speed;
}