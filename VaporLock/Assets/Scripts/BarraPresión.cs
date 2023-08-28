using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarraPresión : MonoBehaviour
{
    public Image barra;
    public float presionActual;
    public float presionMaxima;

    public float velocidad;

    void Update()
    {
        barra.fillAmount = presionActual / presionMaxima;
        
        Presion();
        AumentoPresion();

    }

    private void Presion()
    {
        presionActual -= Time.deltaTime * velocidad;
    }

    private void AumentoPresion()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            presionActual += 5f;
        }
    }
}
