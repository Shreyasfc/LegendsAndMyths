using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class AI_and_collision : MonoBehaviour {

		public GameObject AI;
		public GameObject AIMainFramework;
		Animator AIanim;
		public GameObject PlayerBody;
		public GameObject PlayerMainFrame;
		Animator Playeranim;
		public bool Vlad = false;
		public float Robinspeed = 7f;
		public float AIForce = 10f;
		public float Playerforce = 7f;
		
		//added
		public CameraShake cmera;
		public GameObject hittext;
		
		//extra new
		public GameObject blood;
		public GameObject text2KO;
		
		
	
	// Use this for initialization
	void Start () {
		AIanim = AIMainFramework.GetComponent<Animator>();
		Playeranim = PlayerMainFrame.GetComponent <Animator>();
		
		//add
		hittext.SetActive (false);
		
		//added
		text2KO.SetActive (false);
	
	}
	
	
	
	void Update () {
		
	
		
		if (Playeranim.GetBool ("FT_Attack") == true && Vlad == true) 
		{
		HealthScript_1.health -= 3f;
		AIanim.SetBool ("RC_Attack", false);
		//added new -
		AIanim.SetBool ("RC_Hurt", true);
		hittext.SetActive (true);
		cmera.shakecamera ();
		
		//extra new
		Instantiate (blood, transform.position, Quaternion.identity);
		
		} 
		
		else if (Playeranim.GetBool ("FT_Attack") == false && Vlad == true)
		{
		AIanim.SetBool ("RC_Hurt", false);
		hittext.SetActive (false);
		}
		
		Vector3 displacement = (PlayerBody.transform.position - AI.transform.position);
		displacement = displacement.normalized;
		bool RHhit = false;
		
		if (Vector2.Distance (PlayerBody.transform.position, AI.transform.position) > 4f ) 
		{
		AI.transform.position += (displacement * Robinspeed * Time.deltaTime);
		AIanim.SetBool ("RC_Attack", false);
		AIanim.SetBool ("RC_Walk", true);
		} 
		else  
		{
		AIanim.SetBool ("RC_Walk", false);
		RHhit = true;
		} 
		
		
		if (HealthScript_1.health <= 0) 
		{	
			AIanim.SetBool ("RC_Walk", false);
			AIanim.SetBool ("RC_Jump", false);
			AIanim.SetBool ("RC_Attack", false);
			AIanim.SetTrigger ("RC_Dead");
			StartCoroutine (Wait());
			text2KO.SetActive (true);
			
		}
		
		if (HealthScript_2.health <=0)
		{
			Playeranim.SetBool ("FT_Attack", false);
			Playeranim.SetBool ("Jump", false);
			Playeranim.SetBool ("Walking_Press", false);
			Playeranim.SetBool ("FZ_Dead", true);
			StartCoroutine (FrankDead ());
			AIanim.SetBool ("RC_Attack", false);
			text2KO.SetActive (true);
		}
		
		
		if (RHhit == true)
		{
			Triggermechanism ();
		}	
			
		
		
		
		if (Playeranim.GetBool ("Jump") == true) {
			AIanim.SetBool ("RC_Jump", true); 
			AIanim.SetBool ("RC_Attack", false);
			
		}
		if (Playeranim.GetBool ("Jump") == false) {
			AIanim.SetBool ("RC_Jump", false); 
			//Removed this attack
		}
		
	
	}
	
	public void Triggermechanism () 
	{
		float attackprob = Random.Range (0f, 100f);
																										//added new
		if (attackprob <= 70f && HealthScript_1.health >= 0 && Playeranim.GetBool ("Jump") == false && AIanim.GetBool ("RC_Hurt") == false) 
		{
			AIanim.SetBool ("RC_Attack", true);
			HealthScript_2.health -= 2f;
			
		}	
		
		
		
	}
	
	
	IEnumerator FrankDead ()
	{
		yield return new WaitForSeconds (2);
		Application.LoadLevel ("Loose");
	}
	
	
	
	IEnumerator Wait ()
		{
		yield return new WaitForSeconds (1);
		Application.LoadLevel ("Win");
		}
	
	
	void OnCollisionEnter(Collision col) 
		{
		Vlad = true;
		}
		
	void OnCollisionExit (Collision col) 
		{
		Vlad = false;
		}
		
		
		
	
	}
	
	

