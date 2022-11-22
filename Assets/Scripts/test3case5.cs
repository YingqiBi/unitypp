using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test3case5 : MonoBehaviour
{
    Rigidbody2D rigidbody;
    float force = 300.0f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    void Jump()
    {
        rigidbody.AddForce(Vector2.up * force);
    }
}