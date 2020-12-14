using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLifeTime : MonoBehaviour
{
    public float timeDestroy = 1.0f;
    void Update()
    {
        Destroy(gameObject,timeDestroy);    
    }
}
