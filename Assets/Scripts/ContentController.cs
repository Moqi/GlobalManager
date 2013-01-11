using UnityEngine;
using System.Collections;

public class ContentController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Before loading WebsiteName = "+GameManager.Instance.WebsiteName);
		GameManager.Instance.WebsiteName = "Revelopment.co.uk";
		Debug.Log("WebsiteName = "+GameManager.Instance.WebsiteName);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
