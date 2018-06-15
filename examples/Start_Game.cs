using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Start_Game : MonoBehaviour {

    public Button startbtn;
    // Use this for initialization
	void Start ()
    {
        Button btn = startbtn.GetComponent<Button>();
        btn.onClick.AddListener(pop);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
   void pop()
    {
        SceneManager.LoadScene("placeholder", LoadSceneMode.Single);
    }
}
