using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRestart : MonoBehaviour
{

    [SerializeField]
    private Transform StartPos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        GameManager.instance.PlayerDead();
        transform.position = StartPos.position;
      
    }
}
