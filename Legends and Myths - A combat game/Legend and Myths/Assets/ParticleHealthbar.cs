using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ParticleHealthbar : MonoBehaviour {
	
	public Image vlad;
	public float Particledistance = 255f;
	public float particlespeed = 7.5f;
	// Use this for initialization
	void Start () {
	
	
	
	}
	
	// Update is called once per frame
	void Update () {
		float fillamount = vlad.fillAmount * particlespeed;
		float xdistance =  Particledistance + fillamount;
		Vector3 dumitru = new Vector3 (xdistance, gameObject.transform.position.y, gameObject.transform.position.z);
		gameObject.transform.position = dumitru;
	}
}
