using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lockpickTrigger : MonoBehaviour
{
    public GameObject botonE;
    public GameObject botonQ;
    public GameObject barra;
    public GameObject[] LockPick;
    public GameObject ganzuas;
    public GameObject[] camara;
    public GameObject[] puertas;
    public GameObject jugador;
    public GameObject victoria;
    private int numRandom;
    private int numPuerta;
    private int cant;

  private void Start()
  {
    puertas = GameObject.FindGameObjectsWithTag("puerta"); 
    jugador = GameObject.Find("Player");
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.E) && puertas[numPuerta].GetComponent<PuertaScript>().activo == true)
    {
      ActivarLockpick();
    }

    if (cant == 2)
    {
      Instantiate(victoria);
    }
  }

  public void BuscarPuerta()
  {
    for (int p = 0; p < puertas.Length; p++)
    {
      if (puertas[p].GetComponent<PuertaScript>().activo == true)
      {
        numPuerta = p;
      }
    }
  }

  private void ActivarLockpick()
  {
      botonQ.SetActive(true);
      botonE.SetActive(false);
      barra.SetActive(true);
      jugador.GetComponent<PlayerMovement>().persoanjeActivo= false;
      numRandom = Random.Range(0 , 4);
      LockPick[numRandom].SetActive(true);
      ganzuas.SetActive(true);
      camara[0].SetActive(false);
      camara[1].SetActive(true);
  }

  public void DesactivarLockpick()
  {
      jugador.GetComponent<PlayerMovement>().persoanjeActivo = true;
      botonQ.SetActive(false);
      barra.SetActive(false);
      LockPick[numRandom].SetActive(false);
      ganzuas.SetActive(false);
      barra.SetActive(false);
      camara[1].SetActive(false);
      camara[0].SetActive(true);
      puertas[numPuerta].GetComponent<PuertaScript>().DesactivarPuerta();
      cant++;
  }
}
