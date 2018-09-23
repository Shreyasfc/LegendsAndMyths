using UnityEngine;
using System.Collections;

public class TriggerWall : MonoBehaviour {

	public GameObject text;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider col) 
	{
	
	text.SetActive (true);
	
	
	}
	
	void OnTriggerExit (Collider col) 
	{
	
	text.SetActive (false);
	HealthScript_2.health = -10f;
		
	
	
	
	}
}
