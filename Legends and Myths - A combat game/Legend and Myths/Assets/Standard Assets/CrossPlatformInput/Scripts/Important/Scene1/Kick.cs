using System;
using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class Kick : MonoBehaviour
    {

        public string Name;
		public GameObject frank;
		Animator animator;
		public string KickAnim;
		public float kickvalue = 0.8f;
		
		void Start () {
		
		animator = frank.GetComponent <Animator>() ;
	
				
		}
		
		
		
        void OnEnable()
        {

        }

        public void SetDownState()
        {
            CrossPlatformInputManager.SetButtonDown(Name);
           	StartCoroutine (Attack ());
           
  			
           	
        }
		
		IEnumerator Attack ()
        {
			animator.SetBool (KickAnim, true);
			yield return new WaitForSeconds (kickvalue);
			animator.SetBool (KickAnim, false);
        }


        public void SetUpState()
        {
            CrossPlatformInputManager.SetButtonUp(Name);
			
			
        }


        public void SetAxisPositiveState()
        {
            CrossPlatformInputManager.SetAxisPositive(Name);
        }


        public void SetAxisNeutralState()
        {
            CrossPlatformInputManager.SetAxisZero(Name);
        }


        public void SetAxisNegativeState()
        {
            CrossPlatformInputManager.SetAxisNegative(Name);
        }

        public void Update()
        {
			
        }
    }
}
