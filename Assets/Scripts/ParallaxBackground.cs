using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    [SerializeField]
    private Vector2 parallaxEffectMultiplier;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = Vector3.zero;
    }

    private void Update()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        
        transform.position += new Vector3( deltaMovement.x*parallaxEffectMultiplier.x, deltaMovement.y * parallaxEffectMultiplier.y,0);
        lastCameraPosition = cameraTransform.position;

    }

}
