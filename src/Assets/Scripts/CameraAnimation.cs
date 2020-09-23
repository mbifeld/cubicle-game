using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimation : MonoBehaviour
{
	//Animation xy = GetComponent<Animation>();
	//public GameObject cam;
	public Animator xy;
	void Start()
	{
		Invoke("camreset", 4f);
	}
    public void camreset()
	{
		xy.enabled = false;
	}

}
