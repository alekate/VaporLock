using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    [SerializeField] public GameObject[] pistones;
    [SerializeField] public GameObject barraPresion;
    
    public GameObject gameManager;
    public GameObject ganzuas;
    private CambioGanzua ganzuasScript;
    public GameObject botonQ;
    private float presion;
    private int contadorPistones;
    public bool botonActivado = false;

    void OnEnable()
    {
      pistones = GameObject.FindGameObjectsWithTag("piston");
      ganzuasScript = ganzuas.GetComponent<CambioGanzua>();
      gameManager = GameObject.Find("GameManager");
    }

    private void Update()
    {
        presion = barraPresion.GetComponent<BarraPresión>().presionActual;

        foreach (GameObject p in pistones)
        {
            if (presion > 55 && presion < 75)
            {
              if (p.GetComponent<piston>().activado == true && p.GetComponent<piston>().contado == false)
              {
                contadorPistones ++;
                p.GetComponent<piston>().contado = true;
                if (contadorPistones == pistones.Length)
                {
                  ganzuasScript.ReinicioGanzua();
                  gameManager.GetComponent<lockpickTrigger>().DesactivarLockpick();
                }
              }
            }else
            {
                contadorPistones = 0;
                p.GetComponent<piston>().Reiniciar();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.CompareTag("punta"))
      {
        botonActivado = true;  
        botonQ.SetActive(botonActivado);
      }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
      if (collision.CompareTag("punta"))
      {
        botonActivado = false;
        botonQ.SetActive(botonActivado);
      }
    }
}
