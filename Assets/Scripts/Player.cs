using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Vector2 InputVec;
    public float Speed;
    Rigidbody2D Rigid;

    void Awake()
    {
        Rigid = GetComponent<Rigidbody2D>();
        Speed = 1;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnMove(InputValue value)
    {
        InputVec = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector2 NextVec =  InputVec * Speed * Time.fixedDeltaTime;
        Rigid.MovePosition(Rigid.position + NextVec);
    }
}
