using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Este script da el movimiento del escenario
public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] private float backgroundScrollSpeed;
    private Material _material;
    private Vector2 offset;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
    }

    void Start()
    {
        offset = new Vector2(0.0f, backgroundScrollSpeed); //Velocidad del vector
    }

    // Update is called once per frame
    void Update()
    {
        _material.mainTextureOffset += offset * Time.deltaTime; //Velocidad en la que se mueve 
    }
}
