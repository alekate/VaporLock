using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraFollow : MonoBehaviour
{
    public Transform target;
    //public GameObject player;
    //private Vector3 offset;      
    

    private void LateUpdate(){
        transform.position = target.position;
        //offset = transform.position;
        //offset = transform.position - player.transform.position;

    }

   // void lateUpdate(){
        //transform.position = player.transform.position + offset;
   // }





}
