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
        // Returns a FLOAT from -1.0 to +1.0

        // Movement
        Vector3 pos = transform.position;

        pos.y += Input.GetAxis("Vertical") * maxSpeed *Time.deltaTime;
        pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;

        transform.position = pos;
	}
}
