#pragma strict
 
public var layerName : String = "Foreground";	// the layer in which the particle should be placed
public var orderInLayer : int = -1;	// -1 to go behind the parent object, 1 to go in front of it
 
public var destroyAfterFinished : boolean = false;
private var pSys : ParticleSystem;

function Start () {
 
	pSys = GetComponent.<ParticleSystem>();
	
	pSys.GetComponent.<Renderer>().sortingLayerName = layerName;
	pSys.GetComponent.<Renderer>().sortingOrder = orderInLayer;
	
	if (destroyAfterFinished)
	{
		Destroy(pSys, pSys.duration + pSys.startDelay + pSys.startLifetime);
	}
}
