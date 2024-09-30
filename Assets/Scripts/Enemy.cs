using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D target;

    bool isAlive;

    Rigidbody2D rigid;
    SpriteRenderer spriter;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        Vector2 dirVec = target.position - rigid.position;
        Vector2 nextVec = dirVec.normalized * Speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
        rigid.linearVelocity = Vector2.zero;
    }

    private void LateUpdate()
    {
        spriter.flipX = target.position.x < rigid.position.x;
    }

    private void OnEnable()
    {
        target = GameManager.instance.Player.GetComponent<Rigidbody2D>();
    }
}
