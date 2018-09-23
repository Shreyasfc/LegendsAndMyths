using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class ButtonHandler1 : MonoBehaviour
    {

        public string Name;
		public GameObject frank;
		Animator animator;
		public GameObject robinHood;
		Animator robinhood1;
	
		
		
		void Start () {
		
		animator = frank.GetComponent <Animator>() ;
		
		}
		
		
        void OnEnable()
        {

        }

        public void SetDownState()
        {
            CrossPlatformInputManager.SetButtonDown(Name);
           	animator.SetBool ("Jump", true);
          
           
  			
           	
        }


        public void SetUpState()
        {
            CrossPlatformInputManager.SetButtonUp(Name);
			animator.SetBool ("Jump", false);
			
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
