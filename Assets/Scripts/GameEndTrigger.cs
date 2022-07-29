using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class GameEndTrigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        collision.GetComponent<PlayerController>().enabled = false;
        GameManager.instance.PlayerReachedFinish();
        collision.GetComponentInChildren<PlayerRestart>().enabled = false;
        Time.timeScale = 0;
        
    }

    
    
}
