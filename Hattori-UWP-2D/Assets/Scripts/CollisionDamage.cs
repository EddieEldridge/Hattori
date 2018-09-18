using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour {

    // Variables
    public float invulnPeriod = 0;
    public int health = 100;
    float invulnTimer = 0;
    int correctLayer;

    void Start()
    {
        correctLayer = gameObject.layer;
    }
    void OnTriggerEnter2D()
    {
        Debug.Log("Trigger!");

        if(invulnTimer <= 0)
        {
            health = health - 50;
            invulnTimer = invulnPeriod;

            gameObject.layer = 10;
        }

    }

    void Update()
    {
        invulnTimer -= Time.deltaTime;

        if(invulnTimer<=0)
        {
            gameObject.layer = correctLayer;
        }

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
