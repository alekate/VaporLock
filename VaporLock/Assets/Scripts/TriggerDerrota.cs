using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDerrota : MonoBehaviour
{
    public GameObject Derrota;
    public float[] rotaciones;
    private int numRotacion = 0;
    public Transform cono;
   private void OnTriggerEnter2D(Collider2D other)
   {

    if (other.GetComponent<Collider2D>().CompareTag("jugador"))
    {
        Debug.Log("te vi");
        Instantiate(Derrota);
        Destroy(this);
    }
   }

   public void Giro()
   {
    if (numRotacion == rotaciones.Length)
    {
      Debug.Log("reinicia");
      numRotacion = 0; 
    }

    cono.eulerAngles = new Vector3(0, 0, cono.eulerAngles.z + rotaciones[numRotacion]);
    numRotacion++;
    
   }
}
