
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager1 gamemanager;
   void OnTriggerEnter ()
    {
        gamemanager.CompleteLevel();
    }
}
