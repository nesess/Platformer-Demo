using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TarodevController;

public class FanForce : MonoBehaviour
{
    [SerializeField]
    private float Force = 50;

    private void OnTriggerEnter2D(Collider2D other)
    {


        PlayerController player = other.GetComponent<PlayerController>();
        player.AddVerticalForce(Force);
       
    }
}
