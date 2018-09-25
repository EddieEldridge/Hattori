using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    // Variables
    Transform player;

	// Use this for initialization
	void Start ()
    {

    
	}
	
	// Update is called once per frame
	void Update ()
    {
        // If the player is null (i.e they are dead)
        if (player == null)
        {
            // Find the players ship
            GameObject go = GameObject.Find("PlayerShip");

            if (go != null)
            {
                player = go.transform;
            }

            else
            {
                Debug.Log("Player not found.");
                return;
            }
        }

        Vector3 dir = player.position - transform.position;
        dir.Normalize();

        // Returns the correct angle (in degrees) on the z axis based on our x and y axis.
        // We don't want to rotate on the x and y axis as it's a 2D game
        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

        transform.rotation = Quaternion.Euler(0, 0, zAngle);
    }
}
