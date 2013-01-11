using UnityEngine;
using System.Collections;

public class SimpleCall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MenuController.Instance.PrintCall("I am calling my menuController");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
