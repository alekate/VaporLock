using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
  public void Reiniciar()
  {
    SceneManager.LoadScene("SampleScene 1");
  }

  public void MenuInicio()
  {
    SceneManager.LoadScene("Menu");
  }
  public void Creditos()
  {
    SceneManager.LoadScene("Creditos");
  }
}
