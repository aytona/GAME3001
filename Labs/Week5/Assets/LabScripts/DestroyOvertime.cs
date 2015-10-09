using UnityEngine;
using System.Collections;

public class DestroyOvertime : MonoBehaviour {

	public float lifeTime;

	void Start()
	{
		Destroy (this.gameObject, lifeTime);
	}
}
