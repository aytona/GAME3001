using UnityEngine;
using System.Collections;

public class Arrive : MonoBehaviour
{
    public Vector3 targetPosition;

    private Steering steering;

	void Start ()
    {
        steering = GetComponent<Steering>();
	}

	void Update ()
    {
        Vector3 accel = steering.Arrive(targetPosition);
        steering.Steer(accel);
        steering.LookWhereYoureGoing();
	}
}
