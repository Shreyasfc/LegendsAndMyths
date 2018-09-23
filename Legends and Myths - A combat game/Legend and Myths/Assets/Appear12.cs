using UnityEngine;
using System.Collections;

public class Appear12 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (fight ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	IEnumerator fight ()
	{
	
		gameObject.SetActive (true);
		yield return new WaitForSeconds (1);
		gameObject.SetActive (false);
	}
	
}
