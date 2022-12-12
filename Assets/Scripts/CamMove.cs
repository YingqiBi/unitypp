using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public Vector2 ThisVec;
    public Vector2 Lastvec;
    public Vector2 DisVec;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        ThisVec = Player.transform.position;
        Lastvec= Player.transform.position;
        DisVec = Player.transform.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.y > Lastvec.y + 2)
        {
           
            this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(this.transform.position.x, Player.transform.position.y - DisVec.y, this.transform.position.z), Time.deltaTime * 5);
            if (Vector2.Distance(this.transform.position, (Lastvec + new Vector2(0,2.5f))) <= 0.1f)
            {
                Lastvec = this.transform.position;
            }
          
        }
    }
}
