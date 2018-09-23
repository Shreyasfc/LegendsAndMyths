using System;
using UnityEngine;
using System.Collections;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class ButtonHandler2 : MonoBehaviour
    {
		public string Name;
		public GameObject frank;
		Animator animator;
		public GameObject robinHood;
		Animator robinhood1;
		public float PunchValue = 0.5f; 
		
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
			animator.SetBool ("FT_Attack", true);
			yield return new WaitForSeconds (PunchValue);
			animator.SetBool ("FT_Attack", false);
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
