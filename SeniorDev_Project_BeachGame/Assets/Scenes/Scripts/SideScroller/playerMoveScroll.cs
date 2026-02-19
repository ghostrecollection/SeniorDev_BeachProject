using UnityEngine;
using System.Collections;


public class playerMoveScroll : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 4f;
    private Rigidbody playerRB;


    public Vector3 jump;
    public float jumpForce = 4f;

    //private bool isFacingRight = true;


    public bool isGrounded;

    public float moveTime = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();

        jump = new Vector3(0.0f, 5f, 0.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerMove = Input.GetAxis("Horizontal");


        playerRB.linearVelocity = new Vector3(playerMove * speed, playerRB.linearVelocity.y, 0);

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            playerRB.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        
    }


    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
}
