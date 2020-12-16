using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHealth : MonoBehaviour
{
   [SerializeField] private float increaseHealth = 10;
   
   private void OnTriggerEnter2D(Collider2D other)
   {
       Player_Life playerLife = other.gameObject.GetComponent<Player_Life>();
       playerLife.LifePlayer +=  increaseHealth;
       Destroy(this.gameObject);
   }
}
