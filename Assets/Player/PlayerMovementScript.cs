using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 5.0f;
    private float gravityValue = -9.81f;

    private bool canRun = false;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Movement();
    }

    void Movement() 
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            //playerVelocity.y = 0f;
        }

        if (transform.GetChild(0).GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("stand_up")) 
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            controller.Move(move * Time.deltaTime * playerSpeed);

            if (move != Vector3.zero)
            {
                gameObject.transform.forward = move;
            }
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
