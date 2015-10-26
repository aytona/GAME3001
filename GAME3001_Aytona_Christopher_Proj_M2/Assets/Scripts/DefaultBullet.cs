using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class DefaultBullet : MonoBehaviour {

    public float speed = 5f;

    private float lifeSpan = 5f;
    // private bool isDestroyed = false;       // For particle system
    private Vector3 myDirection = Vector3.left;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(LifespanCoroutine());
    }

    void FixedUpdate()
    {
        rb.AddForce(myDirection * speed);
    }

    private IEnumerator LifespanCoroutine()
    {
        yield return new WaitForSeconds(this.lifeSpan);
        Destroy(this.gameObject);
    }
}
