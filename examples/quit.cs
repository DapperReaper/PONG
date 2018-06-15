using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class quit : MonoBehaviour {

    public Button quitbtn;
    // Use this for initialization
    void Start()
    {
        Button btn = quitbtn.GetComponent<Button>();
        btn.onClick.AddListener(done);
       

    }

    // Update is called once per frame
    void Update () {

    }
    void done()
    {
        Application.Quit();
    }
}
