#pragma strict

public var speed : float = 10f;

public var moveX : boolean = true;
public var minX : float = -6.0;
public var maxX : float = 6.0;
public var moveY : boolean = false;
public var minY : float = -4.3;
public var maxY : float = 4.3;

private var missileScript : Missile;

function Start()
{
	missileScript = GetComponent.<Missile>();
}

function Update () {

	if (!missileScript.hasLaunched)
	{
		var move = Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
	//	transform.position += move * speed * Time.deltaTime;
		
		var pos : Vector3 = transform.position;
		if (moveX)
			pos.x = Mathf.Clamp(pos.x + move.x * speed * Time.deltaTime, minX, maxX);
			
		if (moveY)
			pos.y = Mathf.Clamp(pos.y + move.y * speed * Time.deltaTime, minY, maxY);
			
		transform.position = pos;
	}
}
