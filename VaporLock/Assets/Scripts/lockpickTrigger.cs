using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lockpickTrigger : MonoBehaviour
{
    public GameObject botonE;
    public GameObject LockPick;

    private void Start()
    {
      botonE.SetActive(false); 
    }

  private void OnTriggerStay2D()
  {
     botonE.SetActive(true);
     
     if (Input.GetKeyDown(KeyCode.E))
     {
        Instantiate(LockPick);
     }
  }

   private void OnTriggerExit2D()
  {
     botonE.SetActive(false);
  }
}
