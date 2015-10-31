using UnityEngine;
using System.Collections;

public class StartAttack : MonoBehaviour {

    public GameObject attackSpawner;

    void Start()
    {
        attackSpawner.SetActive(false);
    }

	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enabler")
        {
            attackSpawner.SetActive(true);
        }
    }
}
