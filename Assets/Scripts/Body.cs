using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Body : MonoBehaviour { 
    public float speed; 
    public float moveinput;
    private Rigidbody2D rb; 
   
    private void Start() 
    {
        rb = GetComponent<Rigidbody2D>(); 

    } private void FixedUpdate()

    { moveinput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveinput * speed, rb.velocity.y); 
    }
}