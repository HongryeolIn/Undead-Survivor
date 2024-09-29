using UnityEngine;

public class Spawner : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GameManager.instance.Pool.Get(0);
        }
    }
}
