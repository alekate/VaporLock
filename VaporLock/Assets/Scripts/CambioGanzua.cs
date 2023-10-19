using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioGanzua : MonoBehaviour
{
    public GameObject[] ganzuas; 
    public GameObject posicionInicial; 

    public GameObject Triggers;

    private int siguiente;
    private int activo;
    
    void OnEnable()
    {
        Triggers = GameObject.Find("Trigger Manager");

        ganzuas[1].GetComponent<Ganzua>().ganzuaActiva = true;
        ganzuas[1].SetActive(true);
    }

    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Q) && Triggers.GetComponent<TriggerManager>().botonActivado == true)
      {
        CambioRapido();
      }
    }

     public void ReinicioGanzua()
    {
       ganzuas[siguiente].GetComponent<Ganzua>().ganzuaActiva = false;
       ganzuas[siguiente].transform.position = posicionInicial.transform.position;
       ganzuas[siguiente].SetActive(false);
    }

    public void CambioRapido()
    {
        for (int g = 0; g < ganzuas.Length; g++)
        {
            if (ganzuas[g].GetComponent<Ganzua>().ganzuaActiva == true)
            {
                activo = g;
            }
        }
            ganzuas[activo].SetActive(false); 
            ganzuas[activo].GetComponent<Ganzua>().ganzuaActiva = false;
 
            siguiente = activo + 1;
            
            if (siguiente == ganzuas.Length)
            {
            siguiente = 0;
            }

            ganzuas[siguiente].SetActive(true);
            ganzuas[siguiente].GetComponent<Ganzua>().ganzuaActiva = true;

        }
}
