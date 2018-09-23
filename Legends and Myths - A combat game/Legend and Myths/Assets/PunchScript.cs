using UnityEngine;
using System.Collections;

public class PunchScript : MonoBehaviour {

	public AudioSource punch;
	public	Animator AttackerMainFrame; 
	public string attackaniamtion;
	public string kickanimation;
	
	
	void Awake ()
	{
		punch.Stop ();
	
	
	
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if (AttackerMainFrame.GetBool (attackaniamtion) == true || AttackerMainFrame.GetBool (kickanimation) == true)
		{
			
			punch.Play();
		
		}
		
		
	}
}
