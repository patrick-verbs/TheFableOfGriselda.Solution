using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PatrickPlayerMovement : MonoBehaviour {
   
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animator;
    private bool isFox;

    // Start is called before the first frame update
    void Start () {
        animator = GetComponent<Animator>();
        animator.SetBool("isFox", false);
        myRigidbody = GetComponent<Rigidbody2D>();     
    }

    // Update is called once per frame
    void Update () 
    { 
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isFox", true);
        }
        
        // if (Input.GetKeyUp(KeyCode.A))
        // {
        //     animator.SetBool("isFox", false);
        // }


        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");  
        UpdateAnimationAndMove();
    }

    void UpdateAnimationAndMove()
    {
         if(change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        } else {
            animator.SetBool("moving", false);
        }
    }

    void TransformCharacter()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            animator.SetBool("isFox", true);
        }
    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition (transform.position + change * speed * Time.deltaTime);
    }
}
