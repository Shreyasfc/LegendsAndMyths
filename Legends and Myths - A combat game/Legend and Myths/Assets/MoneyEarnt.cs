using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoneyEarnt : MonoBehaviour {

	public Text Bankbalance; 
	public int MoneyInBank;

	// Use this for initialization
	void Start () {
		GameObject.FindGameObjectWithTag ("Bank").GetComponent<MoneyStorage> ().Money100 ();
		MoneyInBank = GameObject.FindGameObjectWithTag ("Bank").GetComponent<MoneyStorage> ().TotalMoney;
	}
	
	// Update is called once per frame
	void Update () {
		Bankbalance.text = MoneyInBank.ToString () ;
	}
}
