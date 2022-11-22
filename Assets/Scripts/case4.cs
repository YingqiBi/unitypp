using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class case4 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector3 moveDirection;
    public bool enableMovement;

    // Update is called once per frame
    private void Update()
    {
        enableMovement = Input.GetKey("space");
    }
    private void FixedUpdate()
    {
        Vector3 movement = moveDirection * Time.fixedDeltaTime * moveSpeed;
        transform.position += movement;
    }
}
