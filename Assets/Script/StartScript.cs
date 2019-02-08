using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScript : MonoBehaviour {

    private Text MaxScoreText;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }

        if (Input.GetKey(KeyCode.R))
        {
            PlayerPrefs.SetInt("MaxScore", 0);
        }

        this.MaxScoreText = this.GetComponent<Text>();
        this.MaxScoreText.text = "MaxScore : " + PlayerPrefs.GetInt("MaxScore");

        if (Input.GetKeyDown(KeyCode.G))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}