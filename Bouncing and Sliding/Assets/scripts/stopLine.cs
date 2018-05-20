using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopLine : MonoBehaviour {

    public GameObject TimerObj;
    // Use this for initialization
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Truck"))
        {
            TimerObj.GetComponent<secondsTimer>().StopTimer();
        }
    }
}
