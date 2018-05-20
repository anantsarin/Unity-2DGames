using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondsTimer : MonoBehaviour {

    public UnityEngine.UI.Text stopwatchText;
    public bool isRunning = false;
    private float timer= 0.0f;
    
    // Use this for initialization
	public void StopTimer () {
        isRunning = false;
	}
	
    public void StartTimer()
    {
        isRunning = true;
    }
	// Update is called once per frame
	void Update () {
		if (isRunning)
        {
            timer += Time.deltaTime;
            stopwatchText.text = "Seconds: " + timer.ToString("F2");
        }
	}
}
