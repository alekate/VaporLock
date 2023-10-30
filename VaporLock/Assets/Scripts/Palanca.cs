using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour
{
  public bool enRango;
  private bool activado = true;
  public GameObject yo;
  public GameObject botonE;
  public GameObject gameManager;
  private Animator animator;
  private string tag;

  [SerializeField] private AudioSource PalancaSFX;

private void Start()
{
    animator = GetComponent<Animator>();
    tag = yo.transform.tag;
}

  private void Update()
  {
      if (Input.GetKeyDown(KeyCode.E) && enRango)
      {
        gameManager.GetComponent<lockpickTrigger>().ContarPlanca(tag); 
        DesactivarPalanca();
        PalancaSFX.Play();
      }
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("jugador") && activado)
    {
      enRango = true;  
      botonE.SetActive(enRango);
    }
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    if (collision.CompareTag("jugador"))
    {
      enRango = false;
      botonE.SetActive(enRango);
    }
  }

  public void DesactivarPalanca()
  {
    animator.SetBool("activado", false); 
    activado = false;  
  }
}
