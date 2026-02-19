using UnityEngine;
using System.Collections;
public class scrollCamFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 5f;

    private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //camera is always trying to get to the pos of the target plus the offset that we stated previously
        Vector3 targetCamPos = target.position + offset;

        //lerp will allow you to move from one value to another

        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothSpeed * Time.deltaTime);
        
    }
}
