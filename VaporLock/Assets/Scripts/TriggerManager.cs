using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    [SerializeField] public GameObject[] pistones;
    [SerializeField] public GameObject barraPresion;

    public GameObject Victoria;

    private float presion;

    private int contadorPistones;

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
                Debug.Log(contadorPistones);
                if (contadorPistones == 4)
                {
                    Destroy(this);
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

}
