using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_EnemyCollisionDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Projectile")
            Destroy(other.gameObject);
    }
}
