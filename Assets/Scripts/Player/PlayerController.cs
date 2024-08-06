using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody Player;
    private float PlayerSpeed = 1000f; 
    private float SideForce = 600f;

    void FixedUpdate()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        Player.velocity =  new Vector3(x * (SideForce * Time.deltaTime), y, PlayerSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Obstacle") {
            this.enabled = false;
        }
    }
}
