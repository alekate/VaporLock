using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaScript : MonoBehaviour
{
    public bool activo;
    public GameObject yo;
    public GameObject botonE;
    public GameObject gameManager;

    [SerializeField] private AudioSource PuertaLock;
    public AudioClip chau;

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.CompareTag("jugador"))
      {
        activo = true;  
        botonE.SetActive(activo);
        PuertaLock.Play();
        gameManager.GetComponent<lockpickTrigger>().BuscarPuerta();
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

    public void DesactivarPuerta()
    {
      yo.SetActive(false);
      PuertaLock.PlayOneShot(chau);
    }
}
