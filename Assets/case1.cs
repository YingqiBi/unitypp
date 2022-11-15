using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class case1 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector3 moveDirection;

    private void FixedUpdate()
    {
        Vector3 movement = moveDirection * Time.fixedDeltaTime * moveSpeed;
        transform.position += movement;
        Debug.Log("FixedUpdate realTime: " + Time.realtimeSinceStartup);
    }
}
