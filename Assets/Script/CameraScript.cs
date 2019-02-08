using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public Transform verRot;//横回転
    public Transform horRot;//縦回転

    public float kando = 3;//感度

    void Start()
    {
        verRot = transform.parent;//親を入れる
        horRot = GetComponent<Transform>();//transformの値を入れる
        Cursor.lockState = CursorLockMode.Locked;//マウスカーソルの固定
        Cursor.visible = false;//カーソルを見えなくする
    }

    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");//マウスの横移動

        float Y_Rotation = Input.GetAxis("Mouse Y");//マウスの縦移動
        verRot.transform.Rotate(0, X_Rotation * kando, 0);//横と感度をかけて親を回す
        horRot.transform.Rotate(-Y_Rotation * kando, 0, 0);//縦と感度をかけてカメラを回す

        if (Input.GetKeyDown(KeyCode.H))
        {
            Cursor.lockState = CursorLockMode.Locked;//Hボタンでいつでもカーソルの固定
            Cursor.visible = false;
        }
    }
}
