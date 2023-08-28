using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ganzua : MonoBehaviour
{
    [SerializeField] private float velocidad = 3f;
    private Rigidbody2D ganzuaRB;
    private float movimientoX;
    private float movimientoY;
    private Vector2 mov;

    void Start()
    {
       ganzuaRB = GetComponent<Rigidbody2D>();        
    }


    void Update()
    {
        movimientoX = Input.GetAxisRaw("Horizontal");
        movimientoY = Input.GetAxisRaw("Vertical");
        mov = new Vector2(movimientoX, movimientoY); 
    }

    private void FixedUpdate()
    {
        ganzuaRB.MovePosition(ganzuaRB.position + mov * velocidad * Time.deltaTime);
    }
}
