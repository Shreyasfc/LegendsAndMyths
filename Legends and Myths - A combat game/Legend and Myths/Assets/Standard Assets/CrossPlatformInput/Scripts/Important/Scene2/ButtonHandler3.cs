using System;
using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class ButtonHandler3 : MonoBehaviour
    {
		public string Name;
		public GameObject frank;
		Animator animator;
		
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
			animator.SetBool ("Attack1", true);
			yield return new WaitForSeconds (0.5f);
			animator.SetBool ("Attack1", false);
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
