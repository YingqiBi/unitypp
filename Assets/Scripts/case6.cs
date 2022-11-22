using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class case6 : MonoBehaviour
{
    public Vector3 moveDirection;
    public bool enableMovement;

    private void FixedUpdate()
    {
        if(enableMovement == true)
        {
            transform.position += moveDirection; 
        }
    }
}
