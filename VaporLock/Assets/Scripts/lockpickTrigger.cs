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
    public GameObject[] camaras;
    public GameObject[] palancas;
    public GameObject[] palancas2;
    public GameObject[] palancas3;
    public GameObject[] puertas;
    public GameObject jugador;
    public GameObject victoria;
    public GameObject puertaPrincipal;
    public GameObject puertaRoja;
    public GameObject puertaVerde;
    private int numRandom;
    private int numPuerta;
    private int cantP;
    private int cantC;
    private int cantV;
    private bool jugadorActivo = true;

  private void Start()
  {
    palancas = GameObject.FindGameObjectsWithTag("palanca");
    palancas2 = GameObject.FindGameObjectsWithTag("palanca2"); 
    palancas3 = GameObject.FindGameObjectsWithTag("palanca3"); 
    puertas = GameObject.FindGameObjectsWithTag("puerta"); 
    jugador = GameObject.Find("Player");
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.E) && puertas[numPuerta].GetComponent<PuertaScript>().activo == true && jugadorActivo)
    {
      ActivarLockpick();
    }

    if (cantP == 3)
    {
      puertaPrincipal.SetActive(false);
    }

      if (cantV == 3)
    {
      puertaVerde.SetActive(false);
    }

      if (cantC == 3)
    {
      puertaRoja.SetActive(false);
    }
  }

  public void BuscarPuerta()
  {
    for (int p = 0; p < puertas.Length; p++)
    {
      if (puertas[p].GetComponent<PuertaScript>().activo == true)
      {
        numPuerta = p;
        Debug.Log(numPuerta);
      }
    }
  }

  public void ContarPlanca(string tag)
  {
    switch (tag)
    {
      case "palanca": 
      cantP ++;
      break;
      case "palanca2": 
      cantC ++;
      break;
      case "palanca3":
      cantV ++;
      break;
      default: 
      Debug.Log("no funciona");
      break;
    }
  }

  private void ActivarLockpick()
  {
      botonQ.SetActive(true);
      botonE.SetActive(false);
      barra.SetActive(true);
      barra.GetComponent<BarraPresión>().presionActual = 50;
      jugador.GetComponent<PlayerMovement>().persoanjeActivo= false;
      jugadorActivo = false;
      numRandom = Random.Range(0 , LockPick.Length);
      LockPick[numRandom].SetActive(true);
      ganzuas.SetActive(true);
      camaras[0].SetActive(false);
      camaras[1].SetActive(true);
  }

  public void DesactivarLockpick()
  {
      jugador.GetComponent<PlayerMovement>().persoanjeActivo = true;
      jugadorActivo = true;
      botonQ.SetActive(false);
      barra.SetActive(false);
      LockPick[numRandom].SetActive(false);
      ganzuas.SetActive(false);
      barra.SetActive(false);
      camaras[1].SetActive(false);
      camaras[0].SetActive(true);
      puertas[numPuerta].GetComponent<PuertaScript>().DesactivarPuerta();
  }
}
