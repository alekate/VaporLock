using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDerrota : MonoBehaviour
{
    public GameObject Victoria;
   private void OnTriggerEnter2D(Collider2D other)
   {

    if (other.GetComponent<Collider2D>().CompareTag("jugador"))
    {
        Debug.Log("te vi");
        Instantiate(Victoria);
        Destroy(this);
    }
   }
}
