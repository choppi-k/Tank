using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public float speed = 2;//移動速度
    
    void Start()
    {

    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.Translate(0, 0, speed * Time.deltaTime);//前に移動
            if (Input.GetKey(KeyCode.LeftShift))
            {
                this.gameObject.transform.Translate(0, 0, speed * Time.deltaTime);//ダッシュ。speedを二回分でspeedの2倍動く
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.Translate(0, 0, -speed * Time.deltaTime);//後ろに移動
        }
    }
}
