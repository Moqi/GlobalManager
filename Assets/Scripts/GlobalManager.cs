/// <summary>
/// Global manager. 
/// Copyright 2012 Carlos Revelo
/// www.revelopment.co.uk
/// 
/// Base class serving as a singleton of a monobehaviour.
/// 
/// Important!!!: DO NOT IMPLEMENT AWAKE ON SUBCLASSES use instead the method Init() like this
/// 
/// protected override void Init()
/// {
/// 	//Your Initialization code here
/// }
/// 
/// Set Persistent true in the inspector to keep active the Object within all scenes.
/// 
/// 
/// </summary>


using UnityEngine;
using System.Collections;

public class GlobalManager<T> : MonoBehaviour {
	
//	Calls DontDestroyOnLoad, mainting this class active throughout the scenes
	[SerializeField]
	bool	_persistent = false;			
	
	private static T _instance;
	
	public static bool	IsInstantiated		{ get { return _instance != null; } }
	protected virtual void	Init() 			{}
	
    public static T Instance
    {
        get
        {
            if (_instance != null)            
                return _instance;            
            else
            {				
				string errorMessage = typeof(T).Name + " is not attached to a gameObject or inactive";
				Debug.LogError(errorMessage);
                throw new System.NullReferenceException(errorMessage);
            }
        }
    }
		
	//IMPORTANT!!!:  DO NOT IMPLEMENT AWAKE ON SUBCLASSES use instead the method Init(). Read the summary at the top.
	void Awake()
	{
		if(Instantiation())
			Init();
	}
	
	bool Instantiation()
	{
		if(IsInstantiated)
		{
			Debug.LogWarning("only one "+typeof(T)+" is allowed, destroying " + gameObject.name);
			Destroy(gameObject);		
			return false;
		}
		
		_instance = (T)(object)this;
		
		if(_persistent)
			DontDestroyOnLoad(this);
		return true;
	}
	
}
