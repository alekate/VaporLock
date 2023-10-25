using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparencia : MonoBehaviour
{
private Animator animator;

private void Start()
{
    animator = GetComponent<Animator>();
}

private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("jugador"))
    {
      animator.SetBool("Activado", true);   
    }
}

private void OnTriggerExit2D(Collider2D collision)
{
    if (collision.CompareTag("jugador"))
    {
      animator.SetBool("Activado", false);   
    }
}

}
