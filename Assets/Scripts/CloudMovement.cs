using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    
    

    [SerializeField]
    private float moveSpeed;

    

    private void Update()
    {

        transform.Translate(Vector3.right * Time.deltaTime*moveSpeed);
        if (transform.position.x >117)
            {
                transform.position = new Vector3(-113,transform.position.y,transform.position.z);
            }
       
        
    }
}
