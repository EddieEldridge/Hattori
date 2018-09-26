using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	// Variables
	public GameObject prefabToSpawn;
	GameObject objectInstance;
	public float respawnTimer;

	// Use this for initialization
	void Start () 
	{
		Spawn();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(objectInstance == null)
		{
			respawnTimer -= Time.deltaTime;

			if(respawnTimer <= 0)
			{
				Spawn();
			}
		}
	}

	void Spawn()
	{		
			objectInstance = (GameObject)Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
	}
}
