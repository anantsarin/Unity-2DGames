using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour {

    public static int numGrabbed = 0, numMissed = 0;
	// Update is called once per frame
	public static void DisplayScore() {
        Debug.Log("G= " + numGrabbed + " M= " + numMissed);
	}
}
