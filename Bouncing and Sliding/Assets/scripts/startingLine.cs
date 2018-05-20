using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startingLine : MonoBehaviour {
    public GameObject TimerObj;
    // Use this for initialization
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Truck"))
        {
            TimerObj.GetComponent<secondsTimer>().StartTimer();
        }
    }
}
