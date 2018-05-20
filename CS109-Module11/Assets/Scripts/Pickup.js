#pragma strict
 
public var coinEffect : GameObject;
private var soundFX : AudioSource;

function Start()
{
	soundFX = GetComponent.<AudioSource>();
}
 
function OnTriggerEnter2D (other : Collider2D) 
{
	if (coinEffect)
		Instantiate(coinEffect, transform.position, transform.rotation);
		
	if (soundFX)
		soundFX.Play();
 
 	gameObject.GetComponent.<Renderer>().enabled = false;
	Destroy(gameObject, 1);
}