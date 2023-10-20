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
    public GameObject[] puertas;
    public GameObject jugador;
    public GameObject victoria;
    public GameObject puertaPrincipal;
    private int numRandom;
    private int numPuerta;
    private int cant;

  private void Start()
  {
    palancas = GameObject.FindGameObjectsWithTag("palanca"); 
    puertas = GameObject.FindGameObjectsWithTag("puerta"); 
    jugador = GameObject.Find("Player");
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.E) && puertas[numPuerta].GetComponent<PuertaScript>().activo == true)
    {
      ActivarLockpick();
    }

    if (cant == 3)
    {
      puertaPrincipal.SetActive(false);
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

  public void ContarPlanca()
  {
    cant++;
  }

  private void ActivarLockpick()
  {
      botonQ.SetActive(true);
      botonE.SetActive(false);
      barra.SetActive(true);
      barra.GetComponent<BarraPresión>().presionActual = 10;
      jugador.GetComponent<PlayerMovement>().persoanjeActivo= false;
      numRandom = Random.Range(0 , LockPick.Length);
      LockPick[numRandom].SetActive(true);
      ganzuas.SetActive(true);
      camaras[0].SetActive(false);
      camaras[1].SetActive(true);
  }

  public void DesactivarLockpick()
  {
      jugador.GetComponent<PlayerMovement>().persoanjeActivo = true;
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
