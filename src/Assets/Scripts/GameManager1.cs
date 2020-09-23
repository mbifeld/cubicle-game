using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    bool gameHasEnded = false;
   public bool gamecomplete = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public GameObject LevelTitle;
	public GameObject Player;
	public GameObject Score;
	public GameObject FakePlayer;
//	public GameObject Camera;
	//public Animation CameraAnim = Camera.GetComponent<Animation>();
	public float delaytimer = 4f;

    void Start()
	{
		Invoke("Startup", delaytimer);
	
	}

    void Startup()
	{
		Player.SetActive(true);
		FakePlayer.SetActive(false);
	//	CameraAnim.enabled = false;
	}
  /*  void Starturp()
	{
	
		Player.SetActive(true);
		FakePlayer.SetActive(false);
	}*/
    

    public void CompleteLevel()
    {
        gamecomplete = true;
        LevelTitle.SetActive(false);
        completeLevelUI.SetActive(true);
    }
   public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
         
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
