using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	[SerializeField]
	SCENES					_sceneToLoad = SCENES.MENU;
	
	public void Load()
	{
		GameManager.Instance.LoadScene(_sceneToLoad);	
	}
	
}
