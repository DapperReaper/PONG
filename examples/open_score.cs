﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class open_score : MonoBehaviour {

    public Button scorebtn;

	// Use this for initialization
	void Start ()
    {
        Button btn = scorebtn.GetComponent<Button>();
        btn.onClick.AddListener(Clicking);
	}
	
	// Update is called once per frame
	void Update () {
        

	}
    void Clicking()
    {
        SceneManager.LoadScene("score", LoadSceneMode.Single);
    }
}
