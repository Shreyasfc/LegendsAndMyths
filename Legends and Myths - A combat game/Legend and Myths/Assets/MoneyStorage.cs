using UnityEngine;
using System.Collections;

public class MoneyStorage : MonoBehaviour {

	public int TotalMoney;
	public int CurrentLevelEarning;
	public int CurrentLoseEarning;
	
	void Awake ()
	{
	
		DontDestroyOnLoad(this.gameObject);
	
	}

	// Use this for initialization
	void Start () {
		TotalMoney = PlayerPrefs.GetInt ("Money");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Money100 ()
	{
		CurrentLevelEarning = 100;
		TotalMoney += CurrentLevelEarning;
		PlayerPrefs.SetInt ("Money", TotalMoney);
	
	}
	
	public void Moneyremoved ()
	{
		CurrentLoseEarning = 500;
		TotalMoney -= CurrentLoseEarning;
		PlayerPrefs.SetInt ("Money", TotalMoney);
	
	}
	
}
