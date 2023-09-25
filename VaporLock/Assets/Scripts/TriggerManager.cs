using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    [SerializeField] public GameObject[] pistones;
    [SerializeField] public GameObject barraPresion;
    public GameObject ganzuas;
    private CambioGanzua ganzuasScript;
    public GameObject botonQ;

    public GameObject Victoria;

    private float presion;

    private int contadorPistones;

    public bool botonActivado = false;

    private void Start()
    {
      ganzuasScript = ganzuas.GetComponent<CambioGanzua>();
      
    }

    void OnEnable()
    {
      pistones = GameObject.FindGameObjectsWithTag("piston");
    }

    private void Update()
    {
        presion = barraPresion.GetComponent<BarraPresión>().presionActual;

        foreach (GameObject p in pistones)
        {
            if (presion > 60 && presion < 90)
            {
              if (p.GetComponent<piston>().activado == true && p.GetComponent<piston>().contado == false)
              {
                contadorPistones ++;
                p.GetComponent<piston>().contado = true;
                if (contadorPistones == pistones.Length)
                {
                    Instantiate(Victoria);
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
