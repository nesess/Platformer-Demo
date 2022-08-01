using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMCameraSwitcher : MonoBehaviour
{

    [SerializeField]
    private int camNumber = 1;

    [SerializeField]
    private Animator myAnim;

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(camNumber==1)
        {
            myAnim.Play("DropAreaVCam");
        }
        else if(camNumber==2)
        {
            myAnim.Play("DropAreaVCam2");
            
        }
        
      
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        myAnim.Play("MainVCam");
    }


}
