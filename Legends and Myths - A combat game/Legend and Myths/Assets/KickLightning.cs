using UnityEngine;
using System.Collections;

public class KickLightning : MonoBehaviour {

	public Animator Kickkdude;
	public GameObject lightning;
	public string Kickname;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Kickkdude.GetBool (Kickname) == true)
		{
			lightning.SetActive (true);
		
				
		}
		
		if (Kickkdude.GetBool (Kickname) == false)
		{
			lightning.SetActive (false);
			
		}
		
		
	}
	
	
	
	
}
