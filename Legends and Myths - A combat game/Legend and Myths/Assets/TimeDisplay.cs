using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

	public Text timerText;
	public TimeStore timestorage; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timerText.text = timestorage.minutes + ":" + timestorage.seconds;
	}
}
