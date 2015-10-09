using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	public Text score = null;
	public Text time = null;

	private static UI instance = null;

	void Awake()
	{
		if (instance == null) {
			GameObject.DontDestroyOnLoad (this.gameObject);
			instance = this;
		} else
			GameObject.Destroy (this.gameObject);
	}

	void Update()
	{
		this.time.text = FormatTime (CountdownTimer.Instance.TimeRemaining);
		this.score.text = "Score: " + PlayerData.Instance.Score.ToString ();
	}

	private string FormatTime(float timeInSeconds)
	{
		return string.Format("{0}:{1:00}", Mathf.FloorToInt(timeInSeconds/60), Mathf.FloorToInt(timeInSeconds % 60));
	}
}
