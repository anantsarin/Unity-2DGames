using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ship : MonoBehaviour {

    public GameObject expl;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 currentPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0);
        Instantiate(expl, currentPos, Quaternion.identity);
        Destroy(gameObject);
    }
}
