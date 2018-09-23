using UnityEngine;
using System.Collections;

public class TimeManger : MonoBehaviour {

	public float slowdownFactor = 0.005f;
	public float slowdownlength = 10f;
	
	void Update ()
	{
	
	 	Time.timeScale += (1f/ slowdownlength) * Time.unscaledDeltaTime;
	 	Time.timeScale = Mathf.Clamp (Time.timeScale, 0f, 1f);
		Time.fixedDeltaTime = Time.timeScale * 0.02f; 
	} 
	
	public void DoSlowMotion ()
	{
		Time.timeScale = slowdownFactor;
	
	
	
	}
}
