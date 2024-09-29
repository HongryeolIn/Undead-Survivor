using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player Player;
    public PoolManager Pool;

    void Awake()
    {
        instance = this;
    }
}
