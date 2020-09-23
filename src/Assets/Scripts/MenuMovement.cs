using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMovement : MonoBehaviour
{
    public float backwardforce;
        public Rigidbody rb;
    void FixedUpdate()
    {
        

        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            rb.AddForce(0,0, backwardforce * Time.deltaTime);
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -backwardforce * Time.deltaTime);
        }
        
    }
}
