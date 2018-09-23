//Name: Robert MacGillivray
//File: ManualCameraClippingEditor.cs
//Date: Jun.01.2015
//Purpose: To add a reset button to the ManualCameraClipping inspector

//Last Updated: Jun.01.2015 by Robert MacGillivray

using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(ManualCameraClipping))]
public class ManualCameraClippingEditor : Editor {

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector (); //draws the default inspector that would be generated

		ManualCameraClipping clippingScript = (ManualCameraClipping)target; //specifies the script to to be affected

		//creates a button with a label as well as a tooltip that, when pressed, triggers a method in the script that resets all layers to the current default
		GUIContent resetDefaultsButton = new GUIContent ("Reset All to Default", "Press this button to reset all layers to the default clipping distance");
		if (GUILayout.Button (resetDefaultsButton))
		{
			clippingScript.ResetDefaults ();
		}
	}
}
