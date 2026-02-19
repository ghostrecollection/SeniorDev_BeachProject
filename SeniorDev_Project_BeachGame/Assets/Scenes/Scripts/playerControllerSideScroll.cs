using UnityEngine;
using System.Collections;

public class playerControllerSideScroll : MonoBehaviour
{
    //movement variables//

    public float walkSpeed;

    private Rigidbody playerRB;

    //making reference to future animation that may or may not be used
    //private Animator myAnim;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        
        //myAnim = GetComponent<Animator>();

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

        playerRB.angularVelocity = new Vector3(playerMove * walkSpeed, playerRB.angularVelocity.y, 0);    



    }
}
