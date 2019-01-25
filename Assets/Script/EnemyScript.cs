using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour {
    int enemyHP = 3;

    private Transform target;
    private float EnemySpeed = 2.0f;
	// Use this for initialization
	void Start () {
        GameObject PlayerObject = GameObject.Find("Player");
        target = PlayerObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target);
        transform.position += transform.forward * EnemySpeed * Time.deltaTime;
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "tama")
        {
            Destroy(col.gameObject);
            //Debug.Log("hit!");
            enemyHP -= 1;
            if(enemyHP <= 0)
            {
                GameObject ScoreObj = GameObject.Find("Score");
                ScoreObj.SendMessage("Scoreplus");

                Destroy(this.gameObject);
            }
        }
    }
}
