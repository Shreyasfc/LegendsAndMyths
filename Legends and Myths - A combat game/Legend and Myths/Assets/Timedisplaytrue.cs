using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timedisplaytrue : MonoBehaviour {

	public string minutes;
	public string seconds;
	public Text TextTimer;

	// Use this for initialization
	void Start () {
		minutes = GameObject.FindGameObjectWithTag ("Time").GetComponent<TimeStore> ().minutes;
		seconds = GameObject.FindGameObjectWithTag ("Time").GetComponent<TimeStore> ().seconds;
		TextTimer.text = minutes + ":" + seconds;
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.isLoadingLevel)
		{
			minutes = "0";
			seconds = "0";
		
		
		}
	
		
	}
}
