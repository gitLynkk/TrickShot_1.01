using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    CharacterController2D controller;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    void Start()
    {
       
    }

    
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }

}
