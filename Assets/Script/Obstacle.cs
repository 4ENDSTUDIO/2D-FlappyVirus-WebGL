using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      

         if(collision.gameObject.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
    private void Update()
    {
        
    }
}
