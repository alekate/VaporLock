using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piston : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name  == "punta")
        {
            transform.DOMove(new Vector2(0f, 1.6), 2f).SetLoops(-1,LoopType.Yoyo);
        }
    }
}
