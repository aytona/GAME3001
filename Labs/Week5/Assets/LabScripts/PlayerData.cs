using UnityEngine;
using System.Collections;

public class PlayerData : Singleton<PlayerData> {

	private int score = 0;
	
	public int Score
	{
		get {
			return this.score;
		}
		set {
			score = value;
		}
	}
}
