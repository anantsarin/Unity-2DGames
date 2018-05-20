using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {

    public GameObject coinEffect;
    public AudioSource SoundFX;
    public int points = 5;
    public string pickedUpBy = "Player";

    private void Start()
    {
        SoundFX = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag(pickedUpBy))
        {
            if (coinEffect)
            {
                Instantiate(coinEffect, transform.position, transform.rotation);
            }
            if (SoundFX)
            {
                SoundFX.Play();
            }
            GetComponent<Renderer>().enabled = false;
            //gameObject.renderer.enabled = false;
            Debug.Log("collide " );
            //if (coll.gameObject.tag == "Enemy")
            //  coll.gameObject.SendMessage("ApplyDamage", 10);
            Destroy(gameObject, 0.4f);
        }

    }

}
