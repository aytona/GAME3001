using UnityEngine;
using System.Collections;

public class Arrive : MonoBehaviour
{
    public Vector3 targetPosition;
    public GameObject enemyBullet;
    public Transform bulletPosition;
    public float rateOfFire = 3f;

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

        if (targetPosition == transform.position)
        {
            StartCoroutine(ShootCoroutine(rateOfFire));
        }
	}

    private IEnumerator ShootCoroutine(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
        }
    }
    
    void Shoot()
    {
        GameObject bullet = Instantiate(this.enemyBullet) as GameObject;
        bullet.transform.position = bulletPosition.transform.position;
        bullet.transform.rotation = bulletPosition.transform.rotation;
    }
}
