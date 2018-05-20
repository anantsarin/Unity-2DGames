using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowMe : MonoBehaviour {

    //public GameObject cameraObj;
    public Transform camTrans;
    public Transform goTrans;
	// Use this for initialization
	void Start () {
        goTrans = transform;
        camTrans = GameObject.FindGameObjectsWithTag("MainCamera")[0].transform;

	}
	
	// Update is called once per frame
	void Update () {
        camTrans.position = new Vector3(goTrans.position.x, goTrans.position.y, camTrans.position.y);
	}
}
