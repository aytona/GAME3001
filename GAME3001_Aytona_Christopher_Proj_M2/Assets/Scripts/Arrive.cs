using UnityEngine;
using System.Collections;

public class Arrive : MonoBehaviour
{
    public Vector3 targetPosition;
    public GameObject AttackSpawner;

    private Steering steering;

	void Start ()
    {
        steering = GetComponent<Steering>();
        AttackSpawner.SetActive(false);
	}

	void Update ()
    {
        Vector3 accel = steering.Arrive(targetPosition);
        steering.Steer(accel);
        steering.LookWhereYoureGoing();

        if (targetPosition.x > transform.position.x)
            AttackSpawner.SetActive(true);
	}
}
