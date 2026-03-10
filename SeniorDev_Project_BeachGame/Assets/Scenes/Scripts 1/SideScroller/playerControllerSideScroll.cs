using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

public class playerControllerSideScroll : MonoBehaviour
{
    //movement variables//

    public float walkSpeed;

    private Rigidbody playerRB;

    private bool facingRight;

    //making reference to future animation that may or may not be used
    //private Animator myAnim;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        
        //myAnim = GetComponent<Animator>();

        facingRight = true;


    }

    // Update is called once per frame
    void Update()
    {        
    }

    private void FixedUpdate()
    {
        //called on a fixed rate after physics rate runs

        float playerMove = Input.GetAxis("Horizontal");
        //myAnim.SetFloat("speed", Mathf.Abs(move));

        playerRB.linearVelocity = new Vector3(playerMove * walkSpeed, playerRB.linearVelocity.y, 0);    

        if(playerMove > 0 && !facingRight)
        {
            Flip();
        }

        else if (playerMove < 0 && facingRight)
        {
            Flip();
        }    

    }

    public void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
    }    
}
