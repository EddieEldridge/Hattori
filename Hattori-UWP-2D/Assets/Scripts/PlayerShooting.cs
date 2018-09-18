using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    // Variables
    public GameObject bulletPrefab;
    public float fireDelay = 0.1f;
    float cooldownTimer = 0;

    // Update is called once per frame
	void Update ()
    {
        cooldownTimer -= Time.deltaTime;

        // Shooting script
		if(Input.GetButton("Fire1") && cooldownTimer <=0)
        {
            Debug.Log("Shooting!");
            cooldownTimer = fireDelay;

            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
	}
}
