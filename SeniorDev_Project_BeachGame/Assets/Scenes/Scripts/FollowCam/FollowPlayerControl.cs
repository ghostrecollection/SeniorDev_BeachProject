using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class FollowPlayerControl : MonoBehaviour
{
    // MOVEMENT AND INPUTS
    // Script reference for move vector.
    private InputManager input;
    public Vector2 jump;

    // CHARACTER CONTROLLER
    public CharacterController controller;

    // MOVEMENT VARIABLES
    public float currentSpeed = 0f;
    public float moveSpeed = 5f;
    public float sprintSpeed = 7f;
    public float jumpForce = 3f;
    

    // GROUNDING
    public bool isGrounded;
    float gravity = -9.81f;
    Vector3 velocity;
    // Layer for ground detection
    public LayerMask groundLayer;
    // Empty location at players feet
    public Transform groundCheck;
    // Raycast distance for ground detection
    private float groundDistance = .4f;


    //ANIMATION
    public Animator anim;
    // Target floats to switch between animations in blend tree
    public static float idleTarget = 0;
    public static float walkTarget = 0.5f;
    public static float sprintTarget = 1;
    // Controls how fast the transition happens
    public float smoothingSpeed = 3f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Grab Player Input Manager Script.
        input = GetComponent<InputManager>();
        // Grab CharacterController
        controller = GetComponent<CharacterController>();

        // Finding Animator.
        anim = GetComponentInChildren<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        // Calling the movement function.
        OnMove();

        // Calling the jump function and checking ground.
        OnJump();
        isGrounded = Physics.Raycast(groundCheck.position, Vector3.down, groundDistance, groundLayer);
        Debug.DrawRay(groundCheck.position, Vector3.down, Color.yellow);

    }

    void OnJump()
    {
        isGrounded = controller.isGrounded;
        if (isGrounded)
        {
            if (input.jump)
            {
                anim.Play("Jump");
                velocity.y = jumpForce;
                input.jump = false;
                
            }

        }
        else
        {
            // Gravity is applied when player is in the air.
            velocity.y -= gravity * -2f * Time.deltaTime;
        }

        // Apply vertical movement (gravity and jumping)
        controller.Move(velocity * Time.deltaTime);
    }

    void OnMove()
    {
        float targetAnimSpeed = 0f;

        currentSpeed = 0;
        // Target direction based of the x and z inputs.
        Vector3 inputDir = new Vector3(input.move.x, 0, input.move.y);
        // Target rotation -- player rotates to direction input.
        float targetRotation = 0;

        // If the move input is not null - do this.
        if (input.move != Vector2.zero)
        {
            // Changes the speed depending on wether or not the player is sprinting.
            if (input.sprint)
            {
                // ADD Play Sprint anim.
                currentSpeed = sprintSpeed;
                targetAnimSpeed = sprintTarget;
            }
            else
            {
                // ADD Play Walk anim.
                currentSpeed = moveSpeed;
                targetAnimSpeed = walkTarget;
            }

            targetRotation = Quaternion.LookRotation(inputDir).eulerAngles.y;
            Quaternion rotation = Quaternion.Euler(0, targetRotation, 0);
            // Smooths movement rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 10 * Time.deltaTime);

        }
        else
        {
            targetAnimSpeed = idleTarget;
            // ADD Play Idle anim.
        }

        // Smooth animation transition using lerp.
        float currentAnimSpeed = anim.GetFloat("Speed");
        float smoothedSpeed = Mathf.Lerp(currentAnimSpeed, targetAnimSpeed, Time.deltaTime * smoothingSpeed);
        anim.SetFloat("Speed", smoothedSpeed);


        Vector3 targetDirection = Quaternion.Euler(0, targetRotation, 0) * Vector3.forward;
        controller.Move(currentSpeed * Time.deltaTime * targetDirection);

    }


    /*public void OnCollisionEnter(Collision collision)
      {
          if (collision.gameObject.CompareTag("ToLevel"))
          {
              LoadScene("3_Level");
          }

          if(collision.gameObject.CompareTag("ToJelly"))
          {
              LoadScene("4_JellyFishJump");
          }

      }*/

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ToLevel"))
        {
            LoadScene("3_Level");
        }

        if (other.gameObject.CompareTag("ToJelly"))
        {
            LoadScene("4_JellyFishJump");
        }

        if(other.gameObject.CompareTag("ToUrchin"))
        {
            LoadScene("5_UrchinCave");
        }
    }
    public void LoadScene(string sceneName)

    {
        SceneManager.LoadScene(sceneName);
    }

    

}
