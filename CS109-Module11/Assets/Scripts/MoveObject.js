#pragma strict

public var xSpeed : int;
public var ySpeed : int;

public var randomX : boolean = false;
public var minXSpeed : int = 100;
public var maxXSpeed : int = 200;

public var randomY : boolean = false;
public var minYSpeed : int = 100;
public var maxYSpeed : int = 200;

public var resize : boolean = true;
public var minSize : float = 0.6f;
public var maxSize : float = 1f;

public var removeOnInvisible : boolean = true;

private var gData : GameData;

function Start () 
{
	if (randomX)
		xSpeed = Random.Range(minXSpeed, maxXSpeed);
		
	if (randomY)
		ySpeed = Random.Range(minYSpeed, maxYSpeed);

	var newSpeed : Vector2;
	newSpeed.x = xSpeed;
	newSpeed.y = ySpeed;
	
	GetComponent.<Rigidbody2D>().AddForce(newSpeed);
	
	if (resize)
	{
		var newSize = Random.Range(minSize, maxSize);
		gameObject.transform.localScale.x = newSize;
		gameObject.transform.localScale.y = newSize;
		
	}
	
	gData = GameObject.Find("SceneManager").GetComponent.<GameData>();
}

function OnBecameInvisible()
{
	if (transform.position.x > 7.0)
	{
		gData.numMissed++;
		gData.DisplayScore();
	}
		
	if (removeOnInvisible)
		Destroy(gameObject);
}

