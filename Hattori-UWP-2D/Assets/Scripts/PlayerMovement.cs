using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Variables
    float maxSpeed = 3.5f;

	void Start ()
    {
		
	}

	void Update ()
    {
        // Rotation for the ship
        

        // Movement for the ship
        Vector3 pos = transform.position;

        pos.y += Input.GetAxis("Vertical") * maxSpeed *Time.deltaTime;
        pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;

        transform.position = pos;
	}
}
