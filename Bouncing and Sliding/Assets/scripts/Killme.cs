using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killme : MonoBehaviour {
    public float killTime;
    // Use this for initialization
    public void Start()
    {
        Invoke("KillMe", killTime);
    }

    // Update is called once per frame
    public void KillMe () {
        Destroy(gameObject);
	}
}
