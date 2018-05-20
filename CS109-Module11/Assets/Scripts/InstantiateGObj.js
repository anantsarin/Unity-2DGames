#pragma strict

public var gObj : GameObject;

public var minX : float;
public var maxX : float;
public var minY : float;
public var maxY : float;

public var startDelay : float = 0f;
public var instantiateDelay : float = 2.0f;

function Start()
{
	InvokeRepeating("CreateRandom", startDelay, instantiateDelay);
}

function StopInstantiating()
{
	CancelInvoke("CreateRandom");
}

function CreateRandom () 
{
    var x : float;
    var y : float;
    
    x = Random.Range(minX, maxX);
    y = Random.Range(minY, maxY);

	var clone : GameObject = Instantiate(gObj, Vector3 (x, y, 0), Quaternion.identity);
	
}

