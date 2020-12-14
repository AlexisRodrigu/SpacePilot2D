using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_EnemyLifeTime : MonoBehaviour
{
    public float timeDestroy = 1.0f;
    void Update()
    {
        Destroy(gameObject,timeDestroy);
    }
}
