#pragma strict

public var liveTime : float = 0.5f;

public var killWithTag : String = "Enemy";

function Start () 
{
	Invoke("DeleteMe", liveTime);
}

function DeleteMe () 
{
	Destroy(gameObject);
}

function OnTriggerEnter2D(other : Collider2D)
{
 	// if explosion has a trigger collider, also kill
 	// Enemy objects in the blast radius
 	
	if (other.gameObject.CompareTag(killWithTag))
 	{
 		Destroy(other.gameObject); 
 	} 	
}
