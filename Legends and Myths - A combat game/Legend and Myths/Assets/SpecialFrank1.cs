using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class SpecialFrank1 : MonoBehaviour {
	
	public GameObject PlayerUI; 
	Animator PlayerAnimator;
	public string PlayerAttackanimation;
	public string JumpAnimation;
	public int counter = 0;
	public GameObject [] Lightning;
	public GameObject fog;
	public GameObject [] AIPlayerControls;
	public GameObject AI;
	Animator Bot;
	public Material skyOne;
	public Material skyTwo;
	public GameObject terrain;
	public AudioSource windformation;
	public GameObject musicalchoir;
	
	public SunShafts sun;
	
	
	void Awake ()
	{
	
		windformation.Stop ();
	
	}
	
	// Use this for initialization
	void Start () {
		PlayerAnimator = PlayerUI.GetComponent<Animator>();
		fog.GetComponent <ParticleSystem> ().enableEmission = false;
		Bot = AI.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (PlayerAnimator.GetBool (PlayerAttackanimation) == true || PlayerAnimator.GetBool (JumpAnimation) == true)
		{
			counter += 1; 
			
		}
		
		if (counter==70) {
			StartCoroutine (superpower1());
		
		}
		
		if (counter == 600) 
		{
			sun.sunShaftIntensity = 6.5f;
			musicalchoir.SetActive (true);
			
		
		}
		
		
		if (counter == 750)
		{
		
			sun.sunShaftIntensity = 0f;
			musicalchoir.SetActive (false);
		}
		
			
	}

	public void Appear ()
	{
	
		foreach (GameObject AIPLCT in AIPlayerControls)
		{
		
		
		AIPLCT.GetComponent<SpriteRenderer>().enabled = false;
		
		}
		
		fog.GetComponent <ParticleSystem> ().enableEmission = true;
		RenderSettings.skybox = skyTwo;
		terrain.SetActive (false);
		
	}
	
	public void Dissapear ()
	{
		foreach (GameObject LZ in Lightning)
		{
			
			LZ.SetActive (false);
			
		}
		
		foreach (GameObject AIPLCT in AIPlayerControls)
		{
			
			
			AIPLCT.GetComponent<SpriteRenderer>().enabled = true;
			
		}
		
		fog.GetComponent <ParticleSystem> ().enableEmission = false;
		
		RenderSettings.skybox = skyOne;
		terrain.SetActive (true);
		
	
	}
	
	public void lightfire ()
	{
	
		foreach (GameObject LZ in Lightning)
		{
			
			LZ.SetActive (true);
			
		}
	
	
	}
	
	IEnumerator superpower1()
	{
		
		Appear ();
		windformation.Play ();
		yield return new WaitForSeconds (4);
		lightfire ();
		yield return new WaitForSeconds (3);
		Dissapear ();
		windformation.Stop ();
	}
	
}
