using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class HealthSpawn : MonoBehaviour
{
    public GameObject prefabItem;
    [SerializeField] private float nextItem = 0.0f;//repeat time
    [SerializeField] private float elapsedTime;
    [SerializeField] private float timeToNextItem = 5.0f;
    void Start()
    {     
        CloneItem();
    }
    
    void Update()
    {
        CloneItem();
    }

    private void CloneItem()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > nextItem)
        {
            float posX = Random.Range(2.5f, -2.5f);
            float posY = Random.Range(2.5f, -2.5f);
            Vector2 randomPosition = new Vector2(posX,posY);
            
            GameObject clone;
            clone = Instantiate(prefabItem, randomPosition, prefabItem.transform.rotation);
            elapsedTime = 0;
            nextItem += timeToNextItem;
        }
        
    }
}
