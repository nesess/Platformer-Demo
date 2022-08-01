using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceTurn : MonoBehaviour
{

    [SerializeField]
    private float turnSpeed = 2f;


    // Start is called before the first frame update
    void Start()
    {
        transform.DORotate(new Vector3(0, 0, 360), turnSpeed, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }

    
}
