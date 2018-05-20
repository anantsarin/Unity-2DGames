using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnclick : MonoBehaviour {

    public void OnMouseDown()
    {
        if (gameObject.transform.position.y > -2 && gameObject.transform.position.y< 4) {
            GameData.numGrabbed++;
            GameData.DisplayScore();
            Destroy(gameObject);
        }
    }
}
