using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithKeys : MonoBehaviour {

    // Use this for initialization
    public float speed = 10f;
	
	// Update is called once per frame
	void Update () {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;

	}
}
