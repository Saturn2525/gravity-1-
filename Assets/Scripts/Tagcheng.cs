using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tagcheng : MonoBehaviour
{
    void Update()
    {
        RoteBtn rotebtnScript;
        GameObject obj = GameObject.Find("Player"); //Player���Ă����I�u�W�F�N�g��T��
        rotebtnScript = obj.GetComponent<RoteBtn>(); //�t���Ă���X�N���v�g���擾

        if (rotebtnScript.BtnL)
        {
                this.tag = "FloorR";
                Debug.Log("�^�O�ύX����R");
        }
        if (rotebtnScript.BtnZP)
        {
                this.tag = "FloorZM";
                Debug.Log("�^�O�ύX����ZM");
        }
        if (rotebtnScript.BtnUP)
        {
                this.tag = "Floor";
                Debug.Log("�^�O�ύX����F");
        }
        if (rotebtnScript.BtnF)
        {
                this.tag = "FloorUP";
                Debug.Log("�^�O�ύX����UP");
        }
        if (rotebtnScript.BtnR)
        {
            this.tag = "FloorL";
            Debug.Log("�^�O�ύX����L");
        }
    }
}
