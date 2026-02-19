using UnityEngine;

public class FollowPlayerControl : MonoBehaviour
{

    public Rigidbody fplayerRB;

    public float moveSpeed;
    public float jumpForce;

    private Vector2 moveInput;

    public Vector3 jump;

    public bool isGrounded;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jump = new Vector3(0.0f, 0.5f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {

        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        moveInput.Normalize();

        fplayerRB.linearVelocity = new Vector3 (moveInput.x * moveSpeed, fplayerRB.linearVelocity.y, moveInput.y * moveSpeed);  
        
        if(Input.GetKey(KeyCode.Space) && isGrounded )
        {
            fplayerRB.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    public void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
}
