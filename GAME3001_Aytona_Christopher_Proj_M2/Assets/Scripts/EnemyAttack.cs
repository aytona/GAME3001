using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

    public float rateOfFire = 3f;
    public GameObject enemyBullet;

    void Awake ()
    {
        StartCoroutine(ShootCoroutine(rateOfFire));
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(this.enemyBullet) as GameObject;
        bullet.transform.position = this.transform.position;
        bullet.transform.rotation = this.transform.rotation;
    }

    private IEnumerator ShootCoroutine(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            Shoot();
        }
    }
}
