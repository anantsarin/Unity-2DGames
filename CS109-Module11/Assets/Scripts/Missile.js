#pragma strict

public var vertSpeed : float = 100.0;
public var explObject : GameObject;

private var rb2D : Rigidbody2D;
public var hasLaunched : boolean = false;

private var gData : GameData;

function Start () 
{
	rb2D = GetComponent.<Rigidbody2D>();
	gData = GameObject.Find("SceneManager").GetComponent.<GameData>();
}
 
function Update () 
{
 	if (! hasLaunched)
 	{
		if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			hasLaunched = true;
			rb2D.AddForce(new Vector2(0.0, vertSpeed));
		}
	}
}
 
 function OnBecameInvisible()
 {
 	//gameObject.SetActive(false);
 	ResetRocket();
 }

function OnTriggerEnter2D(other : Collider2D)
 {
 	if (other.gameObject.CompareTag("Enemy"))
 	{
 		gData.numGrabbed++;
 		gData.DisplayScore();
 		// create the explosion at the same coordinates as the plane (other.gameObject)
 		Instantiate(explObject, Vector3 (transform.position.x, transform.position.y, 0), Quaternion.identity);
 		Destroy(other.gameObject); 
 		transform.position.y = 10;
 		//Invoke("ResetRocket", 1);	// if we exploded a plane, reset after 1 second
 	}
 	
 }

function ResetRocket()
{
	rb2D.isKinematic = true; // stop rocket from moving
	transform.position.x = 0;
	transform.position.y = -4.63;
	hasLaunched = false;
	rb2D.isKinematic = false; // allow rocket to move again
}

