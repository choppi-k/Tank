using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamaGo : MonoBehaviour {
    float tamaSpeed = 500f;
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
    }
	
	// Update is called once per frame
	void Update () {

    }
}