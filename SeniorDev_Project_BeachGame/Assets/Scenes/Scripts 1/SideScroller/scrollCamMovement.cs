using UnityEngine;
using System.Collections;

public class scrollCamMovement : MonoBehaviour
{

    public Transform player;

    public float smoothing;
    public Vector3 offsetPos;

    public Vector2 maxPos;
    public Vector2 minPos;  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != player.position)
        {
            Vector3 targetPosition = new Vector3(player.position.x, player.position.y, transform.position.z);
            targetPosition.x = Mathf.Clamp(targetPosition.x, minPos.x, maxPos.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPos.y, maxPos.y);

            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);


        }
        
    }
}
