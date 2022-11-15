using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public bool a,b;
    // Start is called before the first frame update
    void Start()
    {
        if (a == b)
        {
            Debug.Log("");
        }
        else if (a == true)
        {
            Debug.Log(a);
        }
        else if (b == true)
            Debug.Log(b);
    }

}
