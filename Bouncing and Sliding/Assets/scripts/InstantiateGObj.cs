using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGObj : MonoBehaviour {

    public GameObject gObj;
    public bool randomX;
    public int Xmin, Xmax;

    public bool randomY;
    public int Ymin , Ymax ;
    // Use this for initialization

    public int delay;
    public int startDelay;

    void Start()
    {
        //createRandom();
        InvokeRepeating("createRandom", startDelay, delay);
    }

    // Update is called once per frame
    void createRandom()
    {
        float x = -6.0F;
        float y= 6.0F;
        if (randomX)
        {
            x = Random.Range(Xmin, Xmax);
        }
        if (randomY)
        {
            y = Random.Range(Ymin, Ymax);
        }
        
        //x = Random.Range(-6.0F, 6.0F);
        //y = 5.68F;

        Instantiate(gObj,new Vector3(x, y, 0), Quaternion.identity);
    }
}
