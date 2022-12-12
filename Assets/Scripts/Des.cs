using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Des : MonoBehaviour
{
    // Start is called before the first frame update
  
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.transform.position.y > this.transform.position.y + 6)
        {
            Destroy(this.gameObject);
        }
    }
}
