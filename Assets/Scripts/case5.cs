using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class case5 : MonoBehaviour
{
    public Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.x = newPosition.x;
        transform.position = currentPosition;
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
