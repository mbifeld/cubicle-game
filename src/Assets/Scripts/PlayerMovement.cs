using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewaysforce = 500f;
    public float upwardforce = 5000f;
    public GameManager1 gamemanager;
    public BoxCollider col;
    public LayerMask GroundLayer;
    
    public bool IsGrounded()
    {
       return (Physics.CheckBox(col.bounds.center, new Vector3 (0.5f,0.5f,0.5f), rb.rotation, GroundLayer));
     
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
		{
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("space") )
		{
          // if(collidervar.jump == true)
          if(IsGrounded())
                rb.AddForce(0, upwardforce * Time.deltaTime, 0);

           //  collidervar.jump = false;
        }

        if (rb.position.y < -1f && !(gamemanager.gamecomplete))
        {
            FindObjectOfType<GameManager1>().EndGame();
        }
    }
    
}
