//Name: Robert MacGillivray
//File: ManualCameraClipping.cs
//Date: Apr.18.2015
//Purpose: To easily give the ability for different far clipping distances to be given to different layers

//Last Updated: Jun.01.2015 by Robert MacGillivray

using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ManualCameraClipping : MonoBehaviour {

	[Tooltip("Set this as the default distance you want clipping to occur across the majority of layers.")]
	public float defaultClipDistance;
	internal float oldDefaultClipDistance; //used to keep track of the old default so that multiple clipping distances can be edited at once
	internal float furthestClipDistance; //used to keep track of the furthest clipping distance set (farClipPlane will be set to this value)
	[Tooltip("In order to work properly, this must always have 32 elements, each corrisponding to the index of your layers. Set each index to set clipping distance of a layer. For example: set Element 0 to 1000 and all objects on the default layer will clip at 1000 units from this camera. The layer names should automatically be appropriately assigned for you though, so you don't have to look them up.")]
	public LayerClipDistance[] layerClipDistances = new LayerClipDistance[32]; 

	void Awake()
	{
		//if we're not playing, and we're in the inspector, we've got some initialization to do
		if (!Application.isPlaying && Application.isEditor)
		{
			oldDefaultClipDistance = defaultClipDistance; //sets up the mass editing of default clipping planes
			//fills up layerClipDistances[] with LayerClipDistance objects if they're null and sets the layer names appropriately
			for (int index = 0; index < 32; index++)
			{
				if (layerClipDistances[index] == null)
				{
					layerClipDistances[index] = new LayerClipDistance();
				}
				if (LayerMask.LayerToName(index) != "")
				{
					layerClipDistances[index].layerName = LayerMask.LayerToName(index);
				}
				else
				{
					layerClipDistances[index].layerName = "Layer Not Defined";
				}
			}
		}
	}

	void Start()
	{
		//This is the only part of the script we want to run when the game is actually being played. It actually assigns the custom clipping distances to the camera
		if (Application.isPlaying)
		{
			//we can only assign clipping plane distances with a float array, so we'll take the float values from the custom class and put them into one
			float[] clipFloatArray = new float[32];
			for (int index = 0; index < 32; index++)
			{
				clipFloatArray[index] = layerClipDistances[index].clipDistance;
			}
			GetComponent<Camera>().layerCullDistances = clipFloatArray; //assigns clipping distances to all layers
		}
	}

	/// <summary>
	/// Everything in the update is to make sure no one sets the size of the layerClipDistances array to a 
	/// number other than 32 (if they did, this script wouldn't work as layerCullDistances cannot be
	/// set with anything other than a float array with 32 elements. If someone does change the size of the 
	/// array, because this script executes in edit mode, the array will be reset to a size of 32. I've also
	/// coded redundancies that salvage as much of the information you've set as possible. Unfortunately, if
	/// you try to set the length of the array to a size smaller than 32, all trailing elements will be reset
	/// to the default value you've specified. This cannot be helped.
	/// </summary>
	void Update()
	{
		//we don't want this script to run when the game is running
		if (!Application.isPlaying)
		{
			//makes sure there are always 32 elements in the layerClipDistances array
			if (layerClipDistances.Length != 32)
			{
				LayerClipDistance[] newLayerClipDistances = new LayerClipDistance[32]; //when the above isn't true, we need to reset the array, but we want to save as much information as possible, so we create a temporary array

				//store all salvageable data in the temporary array
				for (int index = 0; index < layerClipDistances.Length; index++)
				{
					newLayerClipDistances[index].clipDistance = layerClipDistances[index].clipDistance;
				}

				//if the array was resized to be smaller than 32, fill the remaining slots in the temp array with the default value
				for (int index = layerClipDistances.Length; index < 32; index++)
				{
					newLayerClipDistances[index].clipDistance = defaultClipDistance;
				}
			
				layerClipDistances = newLayerClipDistances; //copy the temporary array into the regular array so that it now has 32 elements again
			}
			else
			{
				//Makes sure that all distances set to the old default are updated if the default has been changed.
				//Used to automatically update the array in any places that are just using the default
				for (int index = 0; index < layerClipDistances.Length; index++)
				{
					if (layerClipDistances[index].clipDistance == oldDefaultClipDistance)
					{
						layerClipDistances[index].clipDistance = defaultClipDistance;
					}
				}

				//searches the array for the furthest distance (clipping distances can not be set to a value larger than the far clip plane on the camera, this will help with that later)
				furthestClipDistance = layerClipDistances[0].clipDistance;
				for(int index = 0; index < layerClipDistances.Length; index++)
				{
					if (layerClipDistances[index].clipDistance > furthestClipDistance)
					{
						furthestClipDistance = layerClipDistances[index].clipDistance;
					}
				}

				//have to make sure that the furthest distance is not less than the near clip plane
				if (furthestClipDistance < GetComponent<Camera>().nearClipPlane || furthestClipDistance == 0)
				{
					furthestClipDistance = GetComponent<Camera>().farClipPlane; //because the far clip plane distance cannot be less than the near clip plane distance, we can safely use that as a default override
					defaultClipDistance = furthestClipDistance;
				}


				GetComponent<Camera>().farClipPlane = furthestClipDistance; //sets the far clip plane to the furthest distance in our array for the reason stated above

				//if any clipping distances are still set to 0, they will be set to the default automatically. Most useful during the first pass.
				for (int index = 0; index < layerClipDistances.Length; index++)
				{
					if (layerClipDistances[index].clipDistance == 0)
					{
						layerClipDistances[index].clipDistance = defaultClipDistance;
					}
				}

				oldDefaultClipDistance = defaultClipDistance; //stores the current default for comparison's sake if a change is made
			}

			for (int index = 0; index < 32; index++)
			{
				if (LayerMask.LayerToName(index) != "")
				{
					layerClipDistances[index].layerName = LayerMask.LayerToName(index);
				}
				else
				{
					layerClipDistances[index].layerName = "Layer Not Defined";
				}
			}
		}
	}

	/// <summary>
	/// Resets all clipping distances to the current default
	/// </summary>
	public void ResetDefaults()
	{
		foreach (LayerClipDistance clipDistance in layerClipDistances)
		{
			clipDistance.clipDistance = defaultClipDistance;
		}
	}

	//don't know if it's a bug, but I'm taking advantage of the fact that if the first public variable
	//in a serializable class is a string, then any public arrays of this class will be renamed
	//this makes it easy to see what layer you're setting clipping distances for in the inspector
	[System.Serializable]
	public class LayerClipDistance
	{
		[ReadOnlyInInspector]
		public string layerName;
		public float clipDistance;
	}
}
