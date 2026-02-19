using UnityEngine;
using System.Collections;


public class scrollCamFollow : MonoBehaviour
{
    public Transform followPlayer;

    public float smoothSpeed;

    public Vector3 offsetPos;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if (followPlayer != null)
        {
            Vector3 desiredPos = followPlayer.position + offsetPos;

            Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);

            followPlayer.position = smoothPos;

        }

    }
}
