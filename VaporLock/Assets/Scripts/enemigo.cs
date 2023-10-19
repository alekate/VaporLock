using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
  public Transform llegada;
  public GameObject[] posiciones;
  public float[] animaciones;
  public int numPosition = 0;
  public int velocidad;
  public Transform objetoEnemigo;
  public Transform cono;
  private Vector3 destino;
  private Animator animatorController;
  
  private void Start()
  {
    destino = posiciones[numPosition].transform.position;
    animatorController = GetComponent<Animator>();
  }

  private void Update()
  {
    objetoEnemigo.transform.position = Vector3.MoveTowards(objetoEnemigo.transform.position, destino, velocidad * Time.deltaTime);

    if (objetoEnemigo.transform.position == posiciones[numPosition].transform.position)
    {
      cambioRumbo();
    }
  }

  private void cambioRumbo()
  {
    cono.GetComponent<TriggerDerrota>().Giro();
    numPosition++;

    if (numPosition < posiciones.Length)
    {
      destino = posiciones[numPosition].transform.position;
    }else
    {
      numPosition = 0;
      destino = posiciones[numPosition].transform.position;
    }
  }

  private void cambioAnim()
  {
    animatorController.SetFloat("HorizontalE", numPosition);
    animatorController.SetFloat("VerticalE", numPosition + 1);
  }
}
