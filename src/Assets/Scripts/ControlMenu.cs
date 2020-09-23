using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour
{
    public Animator anim;
    public Rigidbody rb;
    public float zfactor;
    public GameObject fakewall;
    public float yfactor;

    public void Controls()
    {
        anim.SetTrigger("EndingButton");
        fakewall.SetActive(false);
        rb.AddForce(0, yfactor, -zfactor);
        
        Invoke("Instruct", 1.2f);
    }
    public void Instruct()
    {
        SceneManager.LoadScene("Instructions");
    }
}
