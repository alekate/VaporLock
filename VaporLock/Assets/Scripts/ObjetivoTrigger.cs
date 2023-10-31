using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetivoTrigger : MonoBehaviour
{
    public GameObject Objetivo;
    public GameObject yo;
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D other)
   {
    if (other.GetComponent<Collider2D>().CompareTag("jugador"))
    {
      Objetivo.SetActive(true);
    }
   }

    private void OnTriggerExit2D(Collider2D other)
   {
    if (other.GetComponent<Collider2D>().CompareTag("jugador"))
    {
      Objetivo.SetActive(false);
    }
   }

   public void DesacPuertaPalanca()
   {
     audioSource.Play();
     Invoke("ChauPuerta", 3f);
   }

   private void ChauPuerta()
   {
     yo.SetActive(false);
   }
}
