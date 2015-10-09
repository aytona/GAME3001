using UnityEngine;
using System.Collections;

public class PlayerCollector : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "PlusScore") {
			PlayerData.Instance.Score++;
			Destroy(other.gameObject);
		}
		if (other.tag == "MinusScore") {
			PlayerData.Instance.Score--;
			Destroy(other.gameObject);
		}
	}
}
