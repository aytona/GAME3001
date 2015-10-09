using UnityEngine;
using System.Collections;

public class CountdownTimer : Singleton<CountdownTimer> {

	// Countdown Timer
	public float time;
	
	private float timeRemaining;
	
	public float TimeRemaining
	{
		get{
			return timeRemaining;
		}
		set{
			timeRemaining = value;
		}
	}
	
	void Start()
	{
		TimeRemaining = time * 60;
	}
	
	void Update()
	{
		TimeRemaining -= Time.deltaTime;
		if (TimeRemaining <= 0)
			Restart ();
	}
	
	private void Restart()
	{
		Application.LoadLevel (Application.loadedLevel);
		TimeRemaining = time * 60;
		PlayerData.Instance.Score = 0;
	}
}
