using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {
    public int xSpeed;
    public int ySpeed;
    public int zSpeed;

    public bool randomX;
    public int Xmin = 100, Xmax = 200;

    public bool randomY;
    public int Ymin = 100, Ymax = 200;

    // Use this for initialization
    void Start () {
        Vector2 newSpeed;
        if (randomX)
        {
            newSpeed.x =Random.Range(Xmin, Xmax);
        }
        else
        {
            newSpeed.x = xSpeed;
        }
        if (randomY)
        {
            newSpeed.y = Random.Range(Ymin, Ymax);
        }
        else
        {
            newSpeed.y = ySpeed;
        }
        
        //newSpeed.z = zSpeed;
        (GetComponent<Rigidbody2D>()).AddForce(newSpeed);
	}
	

}
