using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaVictoria : MonoBehaviour
{
   public bool activo;
    public GameObject yo;
    public GameObject botonE;
    public GameObject Victoria;

private void Update()
{
    if(Input.GetKeyDown(KeyCode.E) && activo)
    {
       Instantiate(Victoria);
    }
}
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.CompareTag("jugador"))
      {
        activo = true;  
        botonE.SetActive(activo);
      }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
      if (collision.CompareTag("jugador"))
      {
        activo = false;
        botonE.SetActive(activo);
      }
    }
}
