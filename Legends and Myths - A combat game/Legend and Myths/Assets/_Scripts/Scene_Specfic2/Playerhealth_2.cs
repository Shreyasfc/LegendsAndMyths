using UnityEngine;
using System.Collections;

public class Playerhealth_2 : MonoBehaviour {

		public GameObject Frank;
		Animator Frank1;
		public GameObject RHood;
		Animator Rhood1;
		public bool Varman = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider col) 
	{
		Varman = true;
	}
	
	void OnTriggerExit (Collider col) 
	{
		Varman = false;
	}
	
}
