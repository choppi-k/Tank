using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameObject ScoreObj = GameObject.Find("Score");
            ScoreObj.SendMessage("NowScoreSave");

            SceneManager.LoadScene("GameOver"); 
            Debug.Log("GameOver");
        }
    }
}
