using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody Player;
    private float PlayerSpeed = 3000f; 
    private float SideForce = 1800f;

    void FixedUpdate()
    {
        var x = Input.GetAxis("Horizontal");

        Player.velocity =  new Vector3(x * (SideForce * Time.deltaTime), -2f, PlayerSpeed * Time.deltaTime);

        if(Player.position.y < -1f) {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Obstacle") {
            enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
