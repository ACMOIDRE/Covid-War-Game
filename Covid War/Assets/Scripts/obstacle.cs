using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    private GameObject  player;

    private void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (Collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
}
