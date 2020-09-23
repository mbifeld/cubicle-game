using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    public GameManager1 gamemanager;
    public Rigidbody rb;

	//  public float a = float.Parse(scoretext.text.Substring(0, 5));
	// public int a = Int32.Parse(scoretext.text)
	public float a;
    void Update()
    {
		// scoretext.text = (player.position.z/7.5).ToString("0")
        if(a>23f)
		{
			scoretext.text = "3";
			a -= Time.deltaTime;
		}
	else	if(a > 22f)
		{
			scoretext.text = "2";
			a -= Time.deltaTime;
		}
	else	if(a > 21)
		{
			scoretext.text = "1";
			a -= Time.deltaTime;
		}

	else	if (a>20f)
		{
			scoretext.text = "GO!";
			a -= Time.deltaTime;
		}

    else if(a>0.0f && a<=20f)
     {
        a -= Time.deltaTime;
        scoretext.text = ("" + a).Substring(0,4);
            }
  else
  {
            scoretext.text = "0.0";
            }
        if(a <= 0.0f && !(gamemanager.gamecomplete))
        {
            rb.AddForce(0, 1000, -5000);
            gamemanager.EndGame();
           }




    }
}
