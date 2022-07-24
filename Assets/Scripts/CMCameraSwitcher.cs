using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMCameraSwitcher : MonoBehaviour
{
 

    private Animator myAnim;

    private void Awake()
    {
        myAnim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myAnim.Play("DropAreaVCam");
        Debug.Log("oldu");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        myAnim.Play("MainVCam");
    }


}
