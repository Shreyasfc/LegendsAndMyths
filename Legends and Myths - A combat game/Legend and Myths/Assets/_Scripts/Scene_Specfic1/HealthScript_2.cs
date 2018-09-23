using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class HealthScript_2 : MonoBehaviour {


	Image healthBar; 
	public float maxHealth = 300f;
	public static float health;

	
	// Use this for initialization
	void Start () {
		healthBar = GetComponent <Image> ();
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		healthBar.fillAmount = health / maxHealth;
		
	
			
			
		
		}
		
		
	
	
}
