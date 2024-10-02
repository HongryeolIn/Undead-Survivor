using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player Player;
    public PoolManager Pool;

    public float GameTime = 0;
    public float maxGameTime = 2f * 10f;

    void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        GameTime += Time.deltaTime;
        if(GameTime > maxGameTime)
        {
            GameTime = maxGameTime;
        }
    }
}
