using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {
	
	public string ayman;
	
	public void Start ()
	{
	Application.LoadLevel (ayman);
	
	
	}
	
}
