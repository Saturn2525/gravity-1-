using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tagcheng : MonoBehaviour
{
    void Update()
    {
        RoteBtn rotebtnScript;
        GameObject obj = GameObject.Find("Player"); //Playerっていうオブジェクトを探す
        rotebtnScript = obj.GetComponent<RoteBtn>(); //付いているスクリプトを取得

        if (rotebtnScript.BtnL)
        {
                this.tag = "FloorR";
                Debug.Log("タグ変更成功R");
        }
        if (rotebtnScript.BtnZP)
        {
                this.tag = "FloorZM";
                Debug.Log("タグ変更成功ZM");
        }
        if (rotebtnScript.BtnUP)
        {
                this.tag = "Floor";
                Debug.Log("タグ変更成功F");
        }
        if (rotebtnScript.BtnF)
        {
                this.tag = "FloorUP";
                Debug.Log("タグ変更成功UP");
        }
        if (rotebtnScript.BtnR)
        {
            this.tag = "FloorL";
            Debug.Log("タグ変更成功L");
        }
    }
}
