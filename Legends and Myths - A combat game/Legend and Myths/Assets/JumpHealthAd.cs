using UnityEngine;
using System.Collections;

public class JumpHealthAd : MonoBehaviour {

	public Animator mainplayer;
	public string jumpAnimation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (mainplayer.GetBool (jumpAnimation) == true)
		{
			HealthScript_2.health += 2f;
			
		}
		
	}
}
