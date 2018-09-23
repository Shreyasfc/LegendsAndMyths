using UnityEngine;
using System.Collections;

public class Screenspeed : MonoBehaviour {

	public Animator text1;
	public float onexspeed = 1f;
	public float twoxspeed = 2f;
	public float threexspeed = 3f;
	public float halfspeed = 0.5f;
	public float quaterspeed = 0.25f;
	

	// Use this for initialization
	void Start () {
	
	
	}
	
	public void nomrmalspeed ()
	{
		text1.speed = onexspeed;
		
	}
	
	public void quickspeed2 ()
	{
		text1.speed = twoxspeed;
	}
	
	
	public void quickspeed3 ()
	{
		text1.speed = threexspeed;
	}
	
	public void quickspeed4 ()
	{
		text1.speed = halfspeed;
	}
	
	public void quickspeed5 ()
	{
		text1.speed = quaterspeed;
	}
	

	
	// Update is called once per frame
	void Update () {
	
	}
}
