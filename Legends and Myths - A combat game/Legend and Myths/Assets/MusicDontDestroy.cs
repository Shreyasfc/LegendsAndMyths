using UnityEngine;
using System.Collections;


public class MusicDontDestroy : MonoBehaviour {

	
	
	void Awake ()
	{
		
		DontDestroyOnLoad (this.gameObject);
		
	}
	
	void Update ()
	{
	
		GameObject [] music = GameObject.FindGameObjectsWithTag ("Music");
		if (music.Length > 1)
			Destroy (this.gameObject);
	
	
	}
	
	
}
