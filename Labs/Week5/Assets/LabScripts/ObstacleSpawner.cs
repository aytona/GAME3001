using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour {

	public GameObject[] objectArray;
	public float delay;

	void Start()
	{
		StartCoroutine (SpawnCoroutine (delay));
	}
	private IEnumerator SpawnCoroutine (float delay)
	{
		while (true)
		{
			yield return new WaitForSeconds (delay);
			Spawn ();
		}
	}
	private void Spawn()
	{
		Vector3 randPosition;
		randPosition = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f));
		randPosition = transform.TransformPoint (randPosition * 0.5f);
		Instantiate (objectArray [Random.Range (0, objectArray.Length)], new Vector3(randPosition.x, 0, randPosition.z), Quaternion.identity);
	}
}
