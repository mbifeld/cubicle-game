using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginningThrow : MonoBehaviour
{
    public Rigidbody rb;
    public float x;
    public float y;
    public float z;
    public GameObject fakewall;
    void Start()
    {
        Invoke("fake", 1f);
        rb.AddForce(x, y, z);

    }
    public void fake()
    {
        fakewall.SetActive(true);
    }

}
