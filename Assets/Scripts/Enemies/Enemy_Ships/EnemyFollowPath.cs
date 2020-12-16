using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPath : MonoBehaviour
{
    //SO QUE TIENE LA CONFIGURACION DE LAS OLAS
    [SerializeField] private WaveConfiguration _waveConfiguration;
    
    [SerializeField] private List<Transform> waypointTransforms; //Guardamos en una lista el camino que seguira el enemigo
    private int waypointIndex = 0;
    
    void Start()
    {
        waypointTransforms = _waveConfiguration.GetWayPoints();//Llamamos del SO la funcion que obtiene la lista de transform
        FindPath();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    //Funcion que busca el camino 
    private void FindPath()
    {
        transform.position = waypointTransforms[waypointIndex].transform.position;
    }

    public void SetWaveConfig(WaveConfiguration waveConfiguration) 
    {
        this._waveConfiguration = waveConfiguration;
    }
    
    private void Move()
    {
        //Verificamos que el numero de waypoints no sea mayor a los totales en el escenario sino destruimos al enemigo
        if (waypointIndex <= waypointTransforms.Count - 1)
        {
            Vector3 targetPosition = waypointTransforms[waypointIndex].transform.position;
            float moveThisFrame = _waveConfiguration.GetMoveSpeed() * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveThisFrame); //Movemos el enemigo a la posicion de nuestros waytransfomr
            
            if (transform.position == targetPosition)
                waypointIndex++;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    

}
