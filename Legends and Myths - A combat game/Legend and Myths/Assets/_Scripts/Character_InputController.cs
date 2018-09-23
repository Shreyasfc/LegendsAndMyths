using UnityEngine;
using System.Collections;

public class Character_InputController : MonoBehaviour {


	public float speed = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float x = Input.GetAxis ("Horizontal");
		x = x * Time.deltaTime * speed;
		
		transform.Translate (x,0f,0f);
	}
}


