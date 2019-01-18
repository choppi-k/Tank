using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamaScript : MonoBehaviour {

    public GameObject tama;
    public Transform hosin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject tamas = Instantiate(tama) as GameObject;

            tama.transform.position = hosin.transform.position;

        }
	}
}
