using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	public float autoLoadNextLevelAfter;
	
	void Start () {
	 Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
	
	}
	
	
	public void LoadLevel (string name){
		Debug.Log ("Level load requested for: " + name);
		Application.LoadLevel (name);
	}
	
	public void QuitRequest () {
		Debug.Log ("I want to Quit");
		Application.Quit ();
	}
	
	public void LoadNextLevel () {
	 Application.LoadLevel (Application.loadedLevel + 1);
	
	}
}
