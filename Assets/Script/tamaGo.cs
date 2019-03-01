using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamaGo : MonoBehaviour {
    float tamaSpeed = 2f;
    Rigidbody rb;
    private GameObject housin;
    private GameObject Reticule;

    Vector3 GoVector;
    Vector3 force;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        housin = GameObject.Find("Launcher");
        Reticule = GameObject.Find("+");

        Vector3 housinposition = housin.transform.position;
        Vector3 Reticuleposition = Reticule.transform.position;

        Destroy(this.gameObject, 5f);
        //force = housin.transform.forward * tamaSpeed; //vector3で飛ばす
        //rb.AddForce(force); //上のおまけ
        GoVector = Reticuleposition - housinposition;
        
        Invoke("DestroyTiming", 4.9f);
    }

    void DestroyTiming()
    {
        GameObject ScoreObj = GameObject.Find("Score");
        ScoreObj.SendMessage("Scoreminus");
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += Time.deltaTime * GoVector * tamaSpeed;
    }
}