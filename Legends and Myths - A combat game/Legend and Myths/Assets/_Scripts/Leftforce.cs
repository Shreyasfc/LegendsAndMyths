using UnityEngine;
using System.Collections;

public class Leftforce : MonoBehaviour {

	public GameObject AIbody;
	public GameObject Playerbody;
	
	void OnTriggerEnter (Collider c)
	{
		float AIforce = 11f;
		float PlayerForce = 8f;
		
		{
		if (c.gameObject.tag == "enemy")
		
		AIbody.GetComponent <Rigidbody> ().AddForce (Vector3.right * AIforce, ForceMode.Acceleration);
		Playerbody.GetComponent <Rigidbody> ().AddForce (Vector3.right * PlayerForce, ForceMode.Acceleration);
		
		
		}
	
	
	
	}
}
