using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {


    public float maxSpeed = 5f;
	
	// Update is called once per frame
	void Update ()
    {
        // Assign players postion to a Vector3 named pos
        Vector3 pos = transform.position;

        // Movement for the ship (Vertical)
        pos.y += maxSpeed * Time.deltaTime;
        transform.position = pos;

    }
}
