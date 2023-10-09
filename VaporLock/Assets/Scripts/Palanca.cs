using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour
{
     public bool activo;
    public GameObject yo;
    public GameObject botonE;
    public GameObject gameManager;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && activo)
        {
          gameManager.GetComponent<lockpickTrigger>().ContarPlanca(); 
          DesactivarPalanca();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.CompareTag("jugador"))
      {
        activo = true;  
        botonE.SetActive(activo);
        gameManager.GetComponent<lockpickTrigger>().ContarPlanca();
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

    public void DesactivarPalanca()
    {
      yo.SetActive(false);
    }
}
