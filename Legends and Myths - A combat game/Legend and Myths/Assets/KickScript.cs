using UnityEngine;
using System.Collections;

public class KickScript : MonoBehaviour {


	public GameObject Frank;
	Animator animator;
	public CameraShake camera1;
	public string Kicktext;
	public GameObject hittext;
	

	// Use this for initialization
	void Start () {
		animator = Frank.GetComponent <Animator> ();
		hittext.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (animator.GetBool (Kicktext) == true)
		{
			hittext.SetActive (true);
			camera1.shakecamera ();
			HealthScript_1.health -= 4f;
			
		} 
	}
}
