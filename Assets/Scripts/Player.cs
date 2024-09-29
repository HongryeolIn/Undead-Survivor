using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Vector2 InputVec;
    public float Speed;

    Rigidbody2D Rigid;
    SpriteRenderer Spriter;
    Animator Anim;

    void Awake()
    {
        Rigid = GetComponent<Rigidbody2D>();
        Spriter = GetComponent<SpriteRenderer>();
        Anim = GetComponent<Animator>();
        Speed = 3f;
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

    private void LateUpdate()
    {
        Anim.SetFloat("Speed", InputVec.magnitude);

        //키를 눌렀을때
        if(InputVec.x != 0)
        {
            //방향에 따라 플레이어의 스프라이트렌더러 Flip X를 컨트롤
            Spriter.flipX = InputVec.x < 0;

        }
    }
}
