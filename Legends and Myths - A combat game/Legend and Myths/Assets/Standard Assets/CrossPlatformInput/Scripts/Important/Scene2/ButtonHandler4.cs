using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class ButtonHandler4 : MonoBehaviour
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
           	animator.SetBool ("Jump1", true);
          
           
  			
           	
        }


        public void SetUpState()
        {
            CrossPlatformInputManager.SetButtonUp(Name);
			animator.SetBool ("Jump1", false);
			
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
