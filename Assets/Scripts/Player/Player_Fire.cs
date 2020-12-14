using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Fire : MonoBehaviour
{
    public Rigidbody2D rbProjectile;
    [SerializeField] private float speedProjectile;
    [SerializeField] private float fireRate = 1.0f;
    [SerializeField] private float nextFire = 0.0f;
   
    private void Update()
    {
        Fire();
    }

    private void Fire()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Rigidbody2D clone;
            clone = Instantiate(rbProjectile, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector2.up * speedProjectile);
        }
    }
}
