using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public int startPoint;
    public Transform[] points; //array of points the platform will move between

    private int i; // index of arrays

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = points[startPoint].position; //setting the pos of the platform to the pos of one of the points
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, points[i].position) <0.2f)
        {
            i++; // increase index

            if( i ==  points.Length)
            {
                i = 0; //reset the indec
            }
        }
        //move platform to the point with the index of i
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }
}
