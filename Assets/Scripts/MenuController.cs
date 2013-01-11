using UnityEngine;
using System.Collections;

public class MenuController : GlobalManager<MenuController> {
	
	
	
	// Use this for initialization
	void Start () {
		Debug.Log("Before loading WebsiteName = "+GameManager.Instance.WebsiteName);
		GameManager.Instance.WebsiteName = "unity.com";
		Debug.Log("WebsiteName = "+GameManager.Instance.WebsiteName);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void PrintCall(string message)
	{
		Debug.Log(message);	
	}
}
