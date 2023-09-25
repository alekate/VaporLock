using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioGanzua : MonoBehaviour
{
    public GameObject[] ganzuas; 
    public GameObject[] posiciones; 

    public GameObject Triggers;

    private int siguiente;
    private int activo;
    
    void Awake()
    {
        //ganzuas = GameObject.FindGameObjectsWithTag("ganzua");
        //posiciones = GameObject.FindGameObjectsWithTag("posición");
    }
    void OnEnable()
    {
        Triggers = GameObject.Find("Trigger Manager");

        ganzuas[1].GetComponent<Ganzua>().ganzuaActiva = true;
        ganzuas[1].SetActive(true);


        //for (int n = 0; n < ganzuas.Length; n++)
        //{
            //ganzuas[n].transform.position = posiciones[n].transform.position;

            //if (n == 1)
           // {
              //  ganzua script = ganzuas[n].GetComponent<ganzua>();

            //    script.ganzuaActiva = true;
          //  }
        //}
    }

    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Q) && Triggers.GetComponent<TriggerManager>().botonActivado == true)
      {
        CambioRapido();
      }
    }

     public void Cambio()
    {
        for (int p = 0; p < posiciones.Length; p++)
        {
            for (int g = 0; g < ganzuas.Length; g++)
            {
                if (posiciones[p].transform.position == ganzuas[g].transform.position)
                {
                    Debug.Log("cambio");
                    siguiente = p++;

                    ganzuas[g].GetComponent<Ganzua>().ganzuaActiva = false;

                    if ((siguiente) <posiciones.Length)
                    {
                        ganzuas[g].transform.position = posiciones[siguiente].transform.position;

                       if (siguiente == 2)
                       {
                            ganzuas[g].GetComponent<Ganzua>().ganzuaActiva = true;
                       }

                    }else
                    {
                        ganzuas[g].transform.position = posiciones[0].transform.position;
                    }
                }
            }
        }
    }

    public void CambioRapido()
    {
        for (int g = 0; g < ganzuas.Length; g++)
        {
            if (ganzuas[g].GetComponent<Ganzua>().ganzuaActiva == true)
            {
                activo = g;
                Debug.Log("activo:" + activo);
            }
        }
            ganzuas[activo].SetActive(false); 
            ganzuas[activo].GetComponent<Ganzua>().ganzuaActiva = false;

            
            siguiente = activo + 1;
            Debug.Log(siguiente);
            
            if (siguiente == ganzuas.Length)
            {
            siguiente = 0;
            }

            ganzuas[siguiente].SetActive(true);
            ganzuas[siguiente].GetComponent<Ganzua>().ganzuaActiva = true;

        }
}
