using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


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

    private const float JUMP_AMT = 10f;
    //
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        
    }//
    //
    // Update is called once per frame
    void Update()
    {
        //
       float playerMove = Input.GetAxis("Horizontal");
        ///
       playerRB.linearVelocity = new Vector3(playerMove * speed, playerRB.linearVelocity.y, 0);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
            playerRB.AddForce(jump * JUMP_AMT, ForceMode.Impulse);
            //isGrounded = false;
        }
        //
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ToUnderwater"))
        {
            LoadScene("2_Underwater");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    public void LoadScene(string sceneName)

    {
        SceneManager.LoadScene(sceneName);
    }
    private void Jump()
    {
        playerRB.angularVelocity = Vector2.up * JUMP_AMT;
    }


}
