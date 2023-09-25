using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganzua : MonoBehaviour
{
    [SerializeField] private float velocidad = 3f;
    private Rigidbody2D personajeRB;
    private float movimientoX;
    private float movimientoY;
    private Vector2 mov;
    public bool ganzuaActiva;


    void Start()
    {
       personajeRB = GetComponent<Rigidbody2D>();        
    }


    void Update()
    {
        if (ganzuaActiva)
        {
            movimientoX = Input.GetAxisRaw("Horizontal");
            movimientoY = Input.GetAxisRaw("Vertical");
            mov = new Vector2(movimientoX, movimientoY);
        }
       
    }

    private void FixedUpdate()
    {
        personajeRB.MovePosition(personajeRB.position + mov * velocidad * Time.deltaTime);
    }

}
