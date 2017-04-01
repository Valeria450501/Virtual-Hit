﻿using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	public VirtualButtonEventHandler virt;
    public static Pause current;
	public bool CanPause;
	// Use this for initialization
	void Start () {
		CanPause = true;
	}

    public void Awake()
    {
        current = this;
    }

    public void SetPause ()
	{
		if(CanPause)
		{
			Debug.Log("pause");
			Time.timeScale=0;
			CanPause = false;
		}
		else
		{
			Time.timeScale=1;
			CanPause=true;
		}
		virt.enabled = !CanPause;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
			SetPause ();
	}
}
