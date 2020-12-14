using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Life : MonoBehaviour
{
    [SerializeField] private float lifePlayer;
    private float initialLife = 1000.0f;
   
    void Start()
    {
        lifePlayer = initialLife;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Mandamos a llamar al script daño projectil en caso de que nos pegue un laser
        DamageProjectile damageProjectile = other.gameObject.GetComponent<DamageProjectile>();
        ProcessHit(damageProjectile);
    }

    private void ProcessHit(DamageProjectile damageProjectile)
    {
        //obtenemos el daño que se le hace al jugador
        lifePlayer -= damageProjectile.GetDamage();
        damageProjectile.Hit();

        if (lifePlayer <= 0)
            Die();
    }

    private void Die()
    {
        Destroy(gameObject);
        //EJECUTAMOS LA ANMIACION
        //Ejecutamos el audio de destruccion
        //Buscamos el level manager
        
    }
}
