using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float velocidad = 3f;
    private Rigidbody2D personajeRB;
    private float movimientoX;
    private float movimientoY;
    private Vector2 mov;
    public bool persoanjeActivo;

    private Animator animatorController;

    [SerializeField] private AudioSource caminar;

    void Start() {
        personajeRB = GetComponent<Rigidbody2D>();
        animatorController = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            animatorController.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        } 
        if (Input.GetAxis("Vertical") != 0)
        {
            animatorController.SetFloat("vertical", Input.GetAxis("Vertical"));
        }

        if (persoanjeActivo)
        {
           movimientoX = Input.GetAxisRaw("Horizontal");
           movimientoY = Input.GetAxisRaw("Vertical");
           mov = new Vector2(movimientoX, movimientoY);
        }

        //if ((Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) && persoanjeActivo)
        //{
          //  caminar.Play();
        //}
        
    }

    private void FixedUpdate() 
    {
        personajeRB.MovePosition(personajeRB.position + mov * velocidad * Time.deltaTime);
    }

}
