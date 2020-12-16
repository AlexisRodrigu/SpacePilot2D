using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Movement : MonoBehaviour
{
    #region Variables para el limite de la camara
    
    private Camera _camera;
    private float min_x;
    private float max_x;
    private float min_y;
    private float max_y;
    #endregion

    #region Variables de movimiento

    private float deltaX, deltaY;
    private Rigidbody2D rb;
    private Collider2D _collider2D;
    private bool touching ;
    #endregion

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _collider2D = GetComponent<Collider2D>();
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.touchCount > 0 && touching == true )
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began :
                    deltaX = touchPosition.x - transform.position.x;
                    deltaY = touchPosition.y - transform.position.y;
                    break;
                case TouchPhase.Moved :
                    rb.MovePosition(new Vector2(touchPosition.x - deltaX, touchPosition.y - deltaY));
                    break;
                case TouchPhase.Ended :
                    rb.velocity = Vector2.zero;
                    break;
            }
        }
    }

    private void OnMouseDown()
    {
        touching = true;
    }

    private void OnMouseUp()
    {
        touching = false;
    }
}
