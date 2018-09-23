using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Purchase : MonoBehaviour {

	public bool Purchasechecker;
	public GameObject close;
	public int MoneyInBank;
	public GameObject error;
	

	// Use this for initialization
	void Start () {
		MoneyInBank = GameObject.FindGameObjectWithTag ("Bank").GetComponent<MoneyStorage> ().TotalMoney;
		error.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
		
	
		if (Purchasechecker==true && MoneyInBank >= 500)
		{
			close.SetActive (false);
			GameObject.FindGameObjectWithTag ("Bank").GetComponent<MoneyStorage> ().Moneyremoved ();
			
			
		} else if (Purchasechecker==true && MoneyInBank <= 500)
		{
		    error.SetActive (true);
		}
		
		
	}
	
	public void MoneyYes ()
	{
	
		Purchasechecker = true;
	}
	

}
