using UnityEngine;
using System.Collections;

public class Cameraefficiency : MonoBehaviour {

	public int xx = 800, yy = 500;
	public Camera cam;

	// Use this for initialization
	void Start () {
		Screen.SetResolution (xx, yy, true);
		cam.aspect = 16f / 9f; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
