using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public CharacterController2D controller;
    public Animator animator;
    public AudioSource audioData;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    void Update(){

        horizontalMove =  Input.GetAxisRaw("HorizontalMove") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {

          jump = true;
          animator.SetBool("IsJumping", true);

          audioData = GetComponent<AudioSource>();
          audioData.Play(0);
          
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
          crouch = false;
        }
    }

    public void OnLanding ()
    {
      animator.SetBool("IsJumping", false);
    }

    public void OnCrouching (bool isCrouching)
    {
      animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate (){
      controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
      jump = false;
    }
}
