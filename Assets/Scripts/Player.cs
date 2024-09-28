using UnityEngine;

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
        InputVec.x = Input.GetAxisRaw("Horizontal");
        InputVec.y = Input.GetAxisRaw("Vertical");
        
    }

    private void FixedUpdate()
    {
        Vector2 NextVec =  InputVec.normalized * Speed * Time.fixedDeltaTime;
        Rigid.MovePosition(Rigid.position + NextVec);
    }
}
