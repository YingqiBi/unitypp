using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class case3 : MonoBehaviour
{
    public Vector3 moveDirection;
    public bool right;
    public bool left;

    // Start is called before the first frame update
    // Update is called once per frame
    private void Update()
    {
        right = Input.GetKey("d");
        left = Input.GetKey("a");
    }

    private void FixedUpdate()
    {
        if (right == true && left == true)
            transform.position = transform.position;
        else if (right == true)
        {
            transform.position += moveDirection;
        }
        else if (left == true)
        {
            transform.position -= moveDirection;
        }
    }
}
