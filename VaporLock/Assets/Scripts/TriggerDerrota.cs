using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDerrota : MonoBehaviour
{
    public GameObject Derrota;
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
    cono.eulerAngles = new Vector3(0, 0, cono.eulerAngles.z + 180f);
   }
}
