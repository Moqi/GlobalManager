/// <summary>
/// GameManager
/// 
/// Copyright 2012 Carlos Revelo
/// www.revelopment.co.uk
/// 
/// 
/// </summary>

using UnityEngine;
using System.Collections;

public enum SCENES 
{
	LOADING,
	MENU,
	CONTENT
}


public class GameManager : GlobalManager<GameManager> {
	
	private	string 		_websiteName = "google";
	
	public string 		WebsiteName { get { return _websiteName; } set { _websiteName = value; } }
	
	protected override void Init()
	{
		Debug.Log("Initializing "+transform.name);
		if(Application.loadedLevelName == SCENES.LOADING.ToString().ToLower())
			LoadScene(SCENES.MENU);
	}
	
	
	
	public void	LoadScene(SCENES sceneToLoad)
	{
		string sceneName = sceneToLoad.ToString().ToLower();
		
		if(Application.loadedLevelName == sceneName)
			return;
		
		Debug.Log("++++++++++Loading "+sceneToLoad.ToString()+" scene++++++++++++");
		Application.LoadLevel(sceneToLoad.ToString().ToLower());	
	}
	
}
