using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    private Rigidbody rb;

    private float horizontalinput;

    private float verticalInput;

    private Vector3 moveInput;

    [SerializeField] private float moveAmount;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical"); 
        moveInput = new Vector3(horizontalinput,0f,verticalInput);
    }

    private void FixedUpdate()
    {
        if (Input.anyKey)
        {
            rb.velocity = -moveInput * moveAmount;
        }
    }
}