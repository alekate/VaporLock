using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private float velocidad = 3f;
    private Rigidbody2D personajeRB;
    private float movimientoX;
    private float movimientoY;
    private Vector2 mov;

    void Start()
    {
       personajeRB = GetComponent<Rigidbody2D>();        
    }


    void Update()
    {
        movimientoX = Input.GetAxisRaw("Horizontal");
        movimientoY = Input.GetAxisRaw("Vertical");
        mov = new Vector2(movimientoX, movimientoY); 
    }

    private void FixedUpdate()
    {
        personajeRB.MovePosition(personajeRB.position + mov * velocidad * Time.deltaTime);
    }
}
