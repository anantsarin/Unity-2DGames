using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            GameData.numMissed++;
            GameData.DisplayScore();
            Destroy(gameObject);
        }
        //Destroy(gameObject);
    }
}
