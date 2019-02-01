using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

    private Text NowScoreText;

	// Use this for initialization
	void Start () {
        this.NowScoreText = this.GetComponent<Text>();
        this.NowScoreText.text = "Score : " + PlayerPrefs.GetInt("score");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Start");
        }
	}
}
