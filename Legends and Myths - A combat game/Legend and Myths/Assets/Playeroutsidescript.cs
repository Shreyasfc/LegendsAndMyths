using UnityEngine;
using System.Collections;

public class Playeroutsidescript : MonoBehaviour {

	Renderer FCrender;
	public bool Movement = false;
	Vector3 orignalpos;
	public GameObject Playerframe;
	Vector3 pframe1;
	
	void Start () {
		FCrender = GetComponent<Renderer>();
		orignalpos = new Vector3 (gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z);
		pframe1 = new Vector3 (Playerframe.transform.localPosition.x, Playerframe.transform.localPosition.y, Playerframe.transform.localPosition.z);
		}
	
	// Update is called once per frame
	void Update () {
		
		
		if (FCrender.isVisible) {
			Debug.Log ("Ye man");
		
		}
		else
		{
			Movement = true; 
			Debug.Log ("No man");
			
		}
		
		if (Movement == true) {
		
			gameObject.transform.position = orignalpos;
			Playerframe.transform.position = pframe1;
		
		}
	
	}	
}

