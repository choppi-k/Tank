using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour {

    private ParticleSystem particle;

    // Use this for initialization
    void Start () {
        particle = this.GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            particle.Play();
        }
    }
}
