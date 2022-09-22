using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public float speed = 150;  

    void FixedUpdate()
    {
        //get horizontal input
        float h = Input.GetAxisRaw("Horizontal");
        //set velocity (movement direction * Speed)
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
