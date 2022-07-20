using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMovement : MonoBehaviour
{
    [SerializeField]
    private Transform destinationPoint;
    private Vector3 startPoint;

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float turnSpeed;

    private bool reached = false;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.position;

    }

    private void FixedUpdate()
    {
        if(reached)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPoint, Time.deltaTime * moveSpeed);
            if (Vector3.Distance(transform.position, startPoint) < 0.2)
            {
                reached = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, destinationPoint.position, Time.deltaTime * moveSpeed);

            if (Vector3.Distance(transform.position, destinationPoint.position) < 0.2)
            {
                reached = true;
            }  
        }
        transform.Rotate(0, 0, turnSpeed*50 * Time.deltaTime);
    }
}
