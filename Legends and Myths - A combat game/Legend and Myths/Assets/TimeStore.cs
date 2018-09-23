using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeStore : MonoBehaviour {

	
	private float startTime;
	public string minutes;
	public string seconds;

	void Awake ()
	{
		DontDestroyOnLoad (this.gameObject);
	
	
	}
	
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	
	
	// Update is called once per frame
	void Update () {
	
		if (Application.isLoadingLevel)
		{
			return;
		} else
		{
			TimeyFimey ();
		}	
		
	}
	
	public void TimeyFimey ()
	{
	
		float t = Time.time - startTime;
		
		minutes = ((int) t /60).ToString ();
		seconds = (t % 60).ToString ("f2");
		
		
	
	}
}
