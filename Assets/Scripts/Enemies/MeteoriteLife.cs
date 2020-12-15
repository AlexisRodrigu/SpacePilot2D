using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteLife : MonoBehaviour
{
    
    [SerializeField] private float healthMeteorite;
    [SerializeField] private int scoreValue;
   

    private void OnTriggerEnter2D(Collider2D other)
    {
        //EL DAÑO DE MI PROJECTILEs
        DamageProjectile damageProjectile = other.GetComponent<DamageProjectile>();
        if (!damageProjectile)   
            return;
        Damage(damageProjectile); //ProcessHit
    }

    private void Damage(DamageProjectile damageProjectile)
    {
        healthMeteorite -= damageProjectile.GetDamage();
        damageProjectile.Hit();
        
        if (healthMeteorite <= 0)
            DieMeteorite();
    }

    private void DieMeteorite()
    {
        Destroy(gameObject);
        GameManager.Instance.AddToScore(scoreValue);
        //Particulas de explosion
    }
}
