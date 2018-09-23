using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Movement : MonoBehaviour {

	public float speed = 2.0f;
	
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			
		float x = CrossPlatformInputManager.GetAxis ("Horizontal");
		x = x * Time.deltaTime * speed;
		transform.Translate (x,0f,0f);	
		
		
		
		} 
		
	}
		
		

		
		
	
	
	

