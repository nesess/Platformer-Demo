using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SawMovement : MonoBehaviour
{
    [SerializeField]
    private Transform destinationPoint;
    private Vector3 startPoint;

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float turnSpeed;

    [SerializeField]
    private float cyleLength = 2;

    private bool reached = false;

    private void Start()
    {
        transform.DOMove(destinationPoint.position, cyleLength).SetEase(Ease.InOutQuad).SetLoops(-1,LoopType.Yoyo);
        transform.DORotate(new Vector3(0, 0, 360),cyleLength*0.5f,RotateMode.FastBeyond360).SetLoops(-1,LoopType.Restart).SetEase(Ease.Linear);
    }



    //Old version
    /* 
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
    */
}
