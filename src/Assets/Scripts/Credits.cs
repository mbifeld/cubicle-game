using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public Rigidbody rb;
    public float yfactor;
    public float zfactor;
    public GameObject fakewall;
    public Animator anim;
    public void Quit()
    {
        anim.SetTrigger("EndingControl");
        fakewall.SetActive(false);
        rb.AddForce(0, yfactor, -zfactor);
        Invoke("Menu", 1.2f);
    }
    public void Menu()
    {

        SceneManager.LoadScene("MainMenu");
    }
}
