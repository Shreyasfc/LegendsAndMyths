using UnityEngine;
using System.Collections;

public class Animation3 : MonoBehaviour {
	
	public GameObject AI;
	public GameObject AIMainFramework;
	Animator AIAnimator;
	public GameObject Player;
	public GameObject PlayerMainframework;
	Animator PlayerAnimator;
	public bool Vlad = false;
	public float AIspeed = 7f;
	public CameraShake cmera;
	public GameObject hittext;
	
	public GameObject blood;
	public GameObject text2KO;
	


	// Use this for initialization
	void Start () {
		AIAnimator = AIMainFramework.GetComponent<Animator>();
		PlayerAnimator = PlayerMainframework.GetComponent <Animator>();
		hittext.SetActive (false);
		text2KO.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 displacement = (Player.transform.position - AI.transform.position);
		displacement = displacement.normalized;
		bool RHhit = false;
	
		
		if (Vector2.Distance (Player.transform.position, AI.transform.position) > 2f ) 
		{
			AI.transform.position += (displacement * AIspeed * Time.deltaTime);
			AIAnimator.SetBool ("RC_Walk", true);
		} else  
		{
			AIAnimator.SetBool ("RC_Walk", false);
			RHhit = true;		
		}
		
		
		if (RHhit == true)
		{
			Triggermechanism ();
		}	 
		
		
		if (PlayerAnimator.GetBool ("Jump") == true) {
			AIAnimator.SetBool ("RC_Jump", true); 
			AIAnimator.SetBool ("RC_Attack", false);
			
			
		}
		if (PlayerAnimator.GetBool ("Jump") == false) {
			AIAnimator.SetBool ("RC_Jump", false); 
		
		}
		
		if (PlayerAnimator.GetBool ("FT_Attack") == true && Vlad == true) 
		{
			HealthScript_1.health -= 3f;
			AIAnimator.SetBool ("RC_Hurt", true);
			AIAnimator.SetBool ("RC_Attack", false);
			cmera.shakecamera ();
			hittext.SetActive (true);
			Instantiate (blood, transform.position, Quaternion.identity);
			
		} 
		else if (PlayerAnimator.GetBool ("FT_Attack") == false && Vlad == true)
		{
			
			AIAnimator.SetBool ("RC_Hurt", false);
			hittext.SetActive (false);
		}
		
		
		if (HealthScript_1.health <= 0) 
		{	
			AIAnimator.SetBool ("RC_Walk", false);
			AIAnimator.SetBool ("RC_Jump", false);
			AIAnimator.SetBool ("RC_Attack", false);
			AIAnimator.SetTrigger ("RC_Dead");
			StartCoroutine (Wait());
			text2KO.SetActive (true);
		}
		
		if (HealthScript_2.health <=0)
		{
			PlayerAnimator.SetBool ("FT_Attack", false);
			PlayerAnimator.SetBool ("Jump", false);
			PlayerAnimator.SetBool ("Walking_Press", false);
			PlayerAnimator.SetBool ("FZ_Dead", true);
			StartCoroutine (FrankDead ());
			AIAnimator.SetBool ("RC_Attack", false);
			
		}
		
	
	
	}
	
	public void Triggermechanism () 
	{
		float attackprob = Random.Range (0f, 100f);
		
		if (attackprob <= 70f && HealthScript_1.health >= 0 && PlayerAnimator.GetBool ("Jump") == false && AIAnimator.GetBool ("RC_Hurt") == false) 
		{
			AIAnimator.SetBool ("RC_Attack", true);
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
	
	
	void OnTriggerEnter(Collider col) 
	{
		Vlad = true;
		Debug.Log ("He came");
	}
	
	void OnTriggerExit (Collider col) 
	{
		Vlad = false;
	}
	
}
