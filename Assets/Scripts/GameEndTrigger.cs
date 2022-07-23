using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class GameEndTrigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponentInParent<PlayerController>().enabled = false;
        GameManager.instance.PlayerReachedFinish();
        collision.GetComponentInParent<PlayerRestart>().enabled = false;
        Time.timeScale = 0;
        
    }

    
    
}
