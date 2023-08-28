using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerManager : MonoBehaviour
{
    [SerializeField] public GameObject[] pistones;
    [SerializeField] public GameObject barraPresion;

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
                    Victoria();
                }
              }
            }else
            {
                p.GetComponent<piston>().Reiniciar();
                Debug.Log("reiniciar");
            }
           
        }
    }

    private void Victoria()
    {
        Debug.Log("ganaste");
    }
}
