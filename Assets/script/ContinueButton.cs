﻿using UnityEngine;
using System.Collections;

public class ContinueButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        Pause.current.SetPause();
        BackButtonDevice.setPreviousScene(Application.loadedLevelName);
        Application.LoadLevel("PauseMenu");
    }
}
