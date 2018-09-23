using UnityEngine;
using System.Collections;

public class InverseCharacter : MonoBehaviour {

	public GameObject AIbody;
	public GameObject Playerbody;
	public float DistanceDeterminerONE;
	
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		
	
		if (Vector3.Distance (AIbody.transform.position, Playerbody.transform.position) < DistanceDeterminerONE)
		{
			Inversechecker3 ();			
		}
		
	
		
	
	}
	
	IEnumerator StopRotation ()
	{
		yield return new WaitForSeconds (3);
	}
	
	
	public void Inversechecker3 () {
	
	
		if  (Playerbody.transform.rotation.y == 180)
		{
			AIbody.transform.localRotation = Quaternion.Euler (0, 0, 0) ;
			Playerbody.transform.localRotation = Quaternion.Euler (0, 0, 0);
			
		}
		
		
		if (Playerbody.transform.rotation.y == 0)
		{
			AIbody.transform.localRotation = Quaternion.Euler (0, 180, 0) ;
			Playerbody.transform.localRotation = Quaternion.Euler (0, 180, 0);
			
		}
	
	
	
	}
	
	
	
}









