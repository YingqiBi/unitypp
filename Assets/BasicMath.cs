using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMath : MonoBehaviour
{
    public float a = 2;
    public float b = 1;

    private void Awake()
    {
        AddSubMultDiv();
    }
    // Start is called before the first frame update
    private void Start()
    {
        AddSubMultDiv();
    }
    private void AddSubMultDiv()
    {
        Debug.Log(a + b);
        Debug.Log(a - b);
        Debug.Log(a * b);
        Debug.Log(a / b);
    }

    private void Add()
    {
        Debug.Log(a + b);
    }

    private void Sub()
    {
        Debug.Log(a - b);
    }

    private void Muly()
    {
        Debug.Log(a * b);
    }

    private void Div()
    {
        Debug.Log(a / b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
