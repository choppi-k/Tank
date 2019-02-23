using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamaGo : MonoBehaviour {
    float tamaSpeed = 1000f;
    Rigidbody rb;
    public GameObject housin;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        housin = GameObject.Find("Launcher");
        Destroy(this.gameObject, 5f);
        Vector3 force;
        force = housin.transform.forward * tamaSpeed;
        rb.AddForce(force);
        Invoke("DestroyTiming", 4.9f);
    }

    void DestroyTiming()
    {
        GameObject ScoreObj = GameObject.Find("Score");
        ScoreObj.SendMessage("Scoreminus");
    }
	
	// Update is called once per frame
	void Update () {

    }
}