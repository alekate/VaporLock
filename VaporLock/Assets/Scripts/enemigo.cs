using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
  public Transform llegada;
  public Transform inicio;
  public int velocidad;
  public Transform objetoEnemigo;
  private Vector3 destino;
  
  private void Start()
  {
    destino = llegada.position;
  }

  private void Update()
  {
    objetoEnemigo.transform.position = Vector3.MoveTowards(objetoEnemigo.transform.position, destino, velocidad * Time.deltaTime);

    if (objetoEnemigo.transform.position == llegada.position)
    {
       StartCoroutine(Giro());
        destino = inicio.position;
    }

    if (objetoEnemigo.transform.position == inicio.position)
    {
        StartCoroutine(Giro());
        destino = llegada.position;
    }
  }

  IEnumerator Giro()
  {
     objetoEnemigo.eulerAngles = new Vector3(0, 0, objetoEnemigo.eulerAngles.z + 180f);
     yield return null;
  }
}
