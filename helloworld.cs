using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helloworld : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Text1;
    void Start()
    {
        //print("Hello World");
        Text1.text = "Hello World";
        //Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
