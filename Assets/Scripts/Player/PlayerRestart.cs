using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRestart : MonoBehaviour
{

    [SerializeField]
    private Transform StartPos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = StartPos.position;
    }
}
