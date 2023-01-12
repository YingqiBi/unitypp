using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public float m_speed;//移动速度
    public float jumpForce;//跳跃力
    Rigidbody2D rb;//获取刚体
    public LayerMask ground;
    public LayerMask cubeb;
    public Collider2D coll;
    public Collider2D cube;
    bool canJump = false;
    public int score;
    public Text text1;
    public Text text2;
    public SpriteRenderer playerSprite;
    private AudioSource audioSource;
    public AudioClip audioClip;

    private void Awake()
    {
        Screen.SetResolution(640, 960, false);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
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
        if (Camera.main.transform.position.y - this.transform.position.y >= 6)
        {
            GameOver.SetActive(true);
        }
    }
    public GameObject GameOver;
    void FixedUpdate()
    {
        //if (float.Parse(string.Format("{0:F1}", transform.position.y)) > 1.0f) return;
        //rb.velocity = new Vector2(rb.velocity.x, jumpForce * Time.deltaTime);//Jump
        Move();

        text1.text = score.ToString();
        text2.text = score.ToString();
    }
    void Move()
    {
        float xm = Input.GetAxis("Horizontal");
        if (xm<0)
        {
            playerSprite.flipX = false;
        }
        else if (xm>0)
        {
            playerSprite.flipX = true;

        }
        rb.velocity = new Vector2(xm * m_speed * Time.deltaTime, rb.velocity.y);
        //if (Input.GetKey("W"))
        //{
        //    canJump = false;
        //}

        if (canJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * Time.deltaTime);//Jump
            audioSource.PlayOneShot(audioClip);
            canJump = false;
        }

        if (this.transform.position.x < -3)
        {
            this.transform.position = new Vector3(3, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.x > 3)
        {
            this.transform.position = new Vector3(-3, this.transform.position.y, this.transform.position.z);
        }
    }

    public void LoadSc()
    {
        SceneManager.LoadScene(0);
    }
}
