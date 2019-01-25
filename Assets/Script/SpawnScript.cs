using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    private float spawntimer;
    public GameObject EnemyPrefab;

    private int whichWall;
    private Vector3 SpawnPoint;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        spawntimer -= Time.deltaTime;
        
        if(spawntimer <= 0.0)
        {
            spawntimer = 1.0f;
            whichWall = Random.Range(1, 5);
            if (whichWall == 1)
            {
                //Debug.Log("1");
                SpawnPoint = new Vector3(-12.5f, Random.Range(0.0f, 7.0f), Random.Range(-12.5f, 12.5f));
            }
            else if (whichWall == 2)
            {
                //Debug.Log("2");
                SpawnPoint = new Vector3(12.5f, Random.Range(0.0f, 7.0f), Random.Range(-12.5f, 12.5f));
            }
            else if (whichWall == 3)
            {
                //Debug.Log("3");
                SpawnPoint = new Vector3(Random.Range(-12.5f, 12.5f), Random.Range(0.0f, 7.0f), -12.5f);
            }
            else //whichWall == 4
            {
                //Debug.Log("4");
                SpawnPoint = new Vector3(Random.Range(-12.5f, 12.5f), Random.Range(0.0f, 7.0f), 12.5f);

            }
            //Debug.Log(whichWall);
            Instantiate(EnemyPrefab, SpawnPoint, Quaternion.identity);
        }
	}
}
