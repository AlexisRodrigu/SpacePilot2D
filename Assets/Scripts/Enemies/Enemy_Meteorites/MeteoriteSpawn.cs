using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MeteoriteSpawn : MonoBehaviour
{
    //Velocidad del movimiento
    // [SerializeField] private EnemySpawner _enemySpawner;
    [SerializeField] private GameObject meteoriteSpawnGO; //Objeto que moveremos
    public Transform wayPointRight, wayPointLeft;
    public Vector3 directionMovement;//Direccion a la que se movera

    //Spawneo del meteorito 
    public Rigidbody2D rbMeteorite;
    [SerializeField] private float speedMeteorite,speedMovement;
    [SerializeField] private float fireRate = 1.0f; //Velocidad de fuego
    [SerializeField] private float nextMeteorite = 0.0f; //siguiente disparo
    
    private void Start()
    {
        directionMovement = wayPointLeft.position;
    }
    private void Update()
    {
        Move();
    }

    private void FixedUpdate()
    {
        Spawn(true);

    }

    private void Move()
    {
        meteoriteSpawnGO.transform.position = Vector3.MoveTowards(meteoriteSpawnGO.transform.position, directionMovement,
            speedMovement * Time.deltaTime);
        
        //Si el meteoritoSpawn llega al punto de izquierda lo regresa a la derecha
        if (meteoriteSpawnGO.transform.position == wayPointLeft.position)
            directionMovement = wayPointRight.position;

        if (meteoriteSpawnGO.transform.position == wayPointRight.position)
            directionMovement = wayPointLeft.position;
    }

    private bool Spawn(bool spawn)
    {
        if (Time.time > nextMeteorite)
        {
            nextMeteorite = Time.time + fireRate;
            Rigidbody2D clone;
            clone = Instantiate(rbMeteorite, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector2.down * speedMeteorite);
        }

        return spawn = true;
    }
}
