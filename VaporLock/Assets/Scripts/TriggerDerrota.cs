using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDerrota : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other)
   {
    Debug.Log("te vi");
    if (other.GetComponent<Collider2D>().CompareTag("jugador"))
    {
        SceneManager.LoadScene("Derrota");
    }
   }
}
