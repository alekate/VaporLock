using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2D;

    [SerializeField] private float speed = 5f;
    [Range(0f, 0.3f)][SerializeField] private float softMovement;

    float mx;
    float my;
    
    void Start() {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        mx = Input.GetAxisRaw("Horizontal");
        my = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate() {
        rb2D.velocity = new Vector2(mx, my).normalized * speed;
    }
}
