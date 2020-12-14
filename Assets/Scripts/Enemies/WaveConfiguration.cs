using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Enemy wave configuration")]
public class WaveConfiguration : ScriptableObject
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject pathPrefab;
    [SerializeField] private float timeBetweenSpaws = 1.0f;
    [SerializeField] private float spawnRandomFactor = 0.5f;
    [SerializeField] private float moveSpeed = 2.0f;
    [SerializeField] private int numberOfEnemies = 3;

    //Obtenemos nuestros enemigos prefab
    public GameObject GetEnemyPrefab() => enemyPrefab;
    
    //Tomamos la lista donde esten los waypoint
    public List<Transform> GetWayPoints()
    {
        var waveWayPoints = new List<Transform>();
        foreach (Transform child in pathPrefab.transform ) //Tomamos los hijos que tenga el path
        {
            waveWayPoints.Add(child);//Se los añadimos
        }

        return waveWayPoints;
    }

    public float GetTimeBeetweenSpaws() => timeBetweenSpaws;
    public float GetSpawnRandomFactor() => spawnRandomFactor;
    public float GetMoveSpeed() => moveSpeed;
    public int GetNumberEnemies() => numberOfEnemies;


}
