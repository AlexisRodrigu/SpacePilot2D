using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public Rigidbody2D rbProjectil;
    [SerializeField] private float speedProjectile;
    [SerializeField] private float fireRate = 1.0f; //Velocidad de fuego
    [SerializeField] private float nextFire = 0.0f; //siguiente disparo

    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Rigidbody2D clone;
            clone = Instantiate(rbProjectil, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector2.down * speedProjectile);
        }        
    }
}
