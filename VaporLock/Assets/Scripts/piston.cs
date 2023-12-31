using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piston : MonoBehaviour
{
   public bool activado = false;
   public bool contado = false;

   [SerializeField] private int velocidad;

   [SerializeField] public Transform posiciónInicial;
   private Vector3 moverHacia;
   [SerializeField] public GameObject pistonObjeto;
   private AudioSource audioSource;
   public AudioClip sonidoActivado;
   public AudioClip sonidoDesactivado;

   private void Awake()
   {
    moverHacia = posiciónInicial.position;
    audioSource = GetComponent<AudioSource>();
   } 

   private void Update()
   {
     if (!activado)
     {
        pistonObjeto.transform.position = Vector3.MoveTowards(pistonObjeto.transform.position, moverHacia, velocidad * Time.deltaTime);
     }
     
   }
   private void OnTriggerEnter2D()
   {
     activado = true;
     audioSource.PlayOneShot(sonidoActivado);
   }

   public void Reiniciar()
   {
     activado = false;
     contado = false;
   }
}
