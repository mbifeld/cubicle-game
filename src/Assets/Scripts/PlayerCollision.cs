using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public bool jump;
  /*  void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Ground")
        {
            jump = true;

        }
       
    } */
    void CollisionTester(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
            jump = true;
        else jump = false;
    }
    
}
