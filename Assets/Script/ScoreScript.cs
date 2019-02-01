using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    public int Score = 0;
    public Text ScoreText;

    public void Scoreplus()
    {
        Score++;

        this.ScoreText = this.GetComponent<Text>();
        this.ScoreText.text = "Score : " + Score;
    }

    public void NowScoreSave()
    {
        PlayerPrefs.SetInt("score", Score);
    }
}