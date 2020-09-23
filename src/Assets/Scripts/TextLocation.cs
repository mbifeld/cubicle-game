using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextLocation : MonoBehaviour
{
    public Text x;
    public void FixedUpdate()
    {
        x.transform.position = new Vector3(60, Screen.height - 20, 0);
        
    }
   
       
}
