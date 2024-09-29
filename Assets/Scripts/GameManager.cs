using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player Player;

    void Awake()
    {
        instance = this;
    }
}
