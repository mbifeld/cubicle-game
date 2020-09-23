
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingButton : MonoBehaviour
{
    public Animator anim;
    public void Start()
    {
        anim.SetTrigger("EndingButton");
        Invoke("StartingAnim", 1.2f);
       
    }
    void StartingAnim()
    {
        SceneManager.LoadScene("Level1");
    }
}
