using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour {

	public Text Moneyamount;
	public int cash;

	// Use this for initialization
	void Start () {
		cash = GameObject.FindGameObjectWithTag ("Bank").GetComponent<MoneyStorage> ().TotalMoney;
	}
	
	// Update is called once per frame
	void Update () {
		Moneyamount.text = cash.ToString ();
	}
}
