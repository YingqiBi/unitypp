using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 StartVec;
    public GameObject Cube1;
    public float UpY;
    public float[] ThisX;
    void Start()
    {
        StartVec = this.transform.position;
        GameObject gameObject1 = GameObject.Instantiate(Cube1);
        Cube1.transform.position = new Vector3(Random.Range(ThisX[0], ThisX[1]), this.transform.position.y+Random.Range(0,2.0f), 0);
        StartVec = Cube1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y > (StartVec + new Vector2(0, UpY)).y)
        {
            GameObject gameObject1 = GameObject.Instantiate(Cube1);
            Cube1.transform.position = new Vector3(Random.Range(ThisX[0], ThisX[1]), this.transform.position.y + Random.Range(0, 2.0f), 0);
            StartVec = Cube1.transform.position;
        }
    }
}
