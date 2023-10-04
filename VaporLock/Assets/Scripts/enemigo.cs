using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
  public Transform llegada;
  public Transform inicio;
  public int velocidad;
  public Transform objetoEnemigo;
  public Transform cono;
  private Vector3 destino;
  private Animator animatorController;
  
  private void Start()
  {
    destino = llegada.position;
    animatorController = GetComponent<Animator>();
  }

  private void Update()
  {
    objetoEnemigo.transform.position = Vector3.MoveTowards(objetoEnemigo.transform.position, destino, velocidad * Time.deltaTime);

    if (objetoEnemigo.transform.position == llegada.position)
    {
      animatorController.SetBool("CambioAnim", true);
      cono.GetComponent<TriggerDerrota>().Giro();
      destino = inicio.position;
    }

    if (objetoEnemigo.transform.position == inicio.position)
    {
       animatorController.SetBool("CambioAnim", false);
        cono.GetComponent<TriggerDerrota>().Giro();
      destino = llegada.position;
    }
  }

}
