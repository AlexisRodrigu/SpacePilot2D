using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [SerializeField] private float healthEnemy;
    [SerializeField] private int scoreValue;

    private void OnTriggerEnter2D(Collider2D other)
    {
        DamageProjectile damageProjectile = other.GetComponent<DamageProjectile>();
        if (!damageProjectile)   
            return;
        Damage(damageProjectile); //ProcessHit
    }

    private void Damage(DamageProjectile damageProjectile)
    {
        healthEnemy -= damageProjectile.GetDamage();
        damageProjectile.Hit();
        
        if (healthEnemy <= 0)
            DieEnemy();
    }

    private void DieEnemy()
    {
        Destroy(gameObject);
        GameManager.Instance.AddToScore(scoreValue);
        //Particulas de explosion
    }
}
