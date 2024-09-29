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

        //Ű�� ��������
        if(InputVec.x != 0)
        {
            //���⿡ ���� �÷��̾��� ��������Ʈ������ Flip X�� ��Ʈ��
            Spriter.flipX = InputVec.x < 0;

        }
    }
}
