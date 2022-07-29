using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRestart : MonoBehaviour
{

    private void Start()
    {
        
    }

    [SerializeField]
    private Transform StartPos;

    private void Dead()
    {
        GameManager.instance.PlayerDead();
        transform.parent.position = StartPos.position;
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.R))
        {
            Dead();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Dead();
      
    }
}
