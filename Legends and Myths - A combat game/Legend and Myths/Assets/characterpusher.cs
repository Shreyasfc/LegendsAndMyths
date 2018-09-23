using UnityEngine;
using System.Collections;

public class characterpusher : MonoBehaviour {
	
	public GameObject AIMainFramework;
	Animator animator;
	Renderer m_renderer;
	
	
	// Use this for initialization
	void Start () {
		animator = AIMainFramework.GetComponent<Animator>();
		m_renderer = GetComponent <Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (m_renderer.isVisible)
		{
			Debug.Log ("Yes visible");
		
		
		}
		else 
		{
			animator.SetTrigger ("FZ_Hurt");
		
		
		}
		
		
		
	}
}
