using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    // Variables
    public float fireDelay = 0.1f;
    float cooldownTimer = 0;

    // Update is called once per frame
	void Update ()
    {
        cooldownTimer -= Time.deltaTime;

        // Shooting script
		if(Input.GetButtonDown("Fire1") && cooldownTimer <=0)
        {
            cooldownTimer = fireDelay;
        }
	}
}
