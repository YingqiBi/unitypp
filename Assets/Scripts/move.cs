using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour
{
    public float m_speed;//移动速度
    public float jumpForce;//跳跃力
    Rigidbody2D rb;//获取刚体
    public LayerMask ground;
    public LayerMask cubeb;
    public Collider2D coll;
    public Collider2D cube;
    bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Update()
    {
        //if(Input.GetKey(KeyCode.Space))
        //{
            //canJump = false;
        //}
        if(Input.GetKey(KeyCode.Space) && coll.IsTouchingLayers(ground))//如果按下跳跃键并且检测到了地面
        //else if(coll.IsTouchingLayers(ground)||cube.IsTouchingLayers(cubeb))
        {
            canJump = true;
        }
    }
    void FixedUpdate()
    {
        //if (float.Parse(string.Format("{0:F1}", transform.position.y)) > 1.0f) return;
        //rb.velocity = new Vector2(rb.velocity.x, jumpForce * Time.deltaTime);//Jump
        Move();
    }
    void Move()
    {
        float xm = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xm * m_speed * Time.deltaTime, rb.velocity.y);
        //if (Input.GetKey("W"))
        //{
        //    canJump = false;
        //}

        if (canJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * Time.deltaTime);//Jump
            canJump = false;
        }
    }

}
