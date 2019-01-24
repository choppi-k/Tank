using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    private float spawntimer;
    public GameObject EnemyPrefab;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        spawntimer -= Time.deltaTime;
        

        if(spawntimer <= 0.0)
        {
            spawntimer = 3.0f;
            Instantiate(EnemyPrefab);
        }
	}
}
