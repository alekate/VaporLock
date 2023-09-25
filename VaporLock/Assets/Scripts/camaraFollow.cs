using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraFollow : MonoBehaviour
{
    public Transform target;

    private void LateUpdate(){
        transform.position = target.position;
    }






}
