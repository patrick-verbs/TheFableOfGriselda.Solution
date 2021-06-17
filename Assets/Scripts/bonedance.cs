using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bonedance : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();     
    }

    // Update is called once per frame
    void Update()
    {
        // change = Vector3.zero;
        // change.x = Input.GetAxisRaw("Horizontal");
        // change.y = Input.GetAxisRaw("Vertical");  
        // UpdateAnimationAndMove();
    }
}



