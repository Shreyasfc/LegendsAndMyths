using UnityEngine;
using System.Collections;

public class Stacking : MonoBehaviour {


	public Animator player;
	public string KickAniamtion;
	public string AttackAniamtion;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (player.GetBool (KickAniamtion) == true)
		{
		
			player.SetBool (AttackAniamtion, false) ;
		
		}
	
		if (player.GetBool (AttackAniamtion) == true)
		{
			
			player.SetBool (KickAniamtion, false);
		
		
		}
	
	
	
	
	}
}
