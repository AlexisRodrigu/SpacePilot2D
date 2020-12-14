using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageProjectile : MonoBehaviour
{
    [SerializeField] private int damage = 100;
    
    //Funcion de flecha que retorna el daño
    public int GetDamage() => damage;
    
    public void Hit()
    {
        Destroy(gameObject);
    }
}
