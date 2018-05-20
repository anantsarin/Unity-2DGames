#pragma strict
import UnityEngine.UI; 
// access from other scripts like GameData.numGrabbed++
public var scoreText: Text;
public var numGrabbed: int = 0;
public var numMissed: int = 0;

function DisplayScore() {

    scoreText.text = "Grabbed: " + numGrabbed + "  Missed: " + numMissed;
}
