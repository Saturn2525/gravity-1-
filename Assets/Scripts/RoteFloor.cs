using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoteFloor : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        RoteBtn rotebtnScript;
        GameObject obj = GameObject.Find("Player"); //Player���Ă����I�u�W�F�N�g��T��
        rotebtnScript = obj.GetComponent<RoteBtn>(); //�t���Ă���X�N���v�g���擾

        if (rotebtnScript.BtnL)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(90f, Vector3.up), 5f);
        }
        else if (rotebtnScript.BtnZP)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(180f, Vector3.right), 5f);
        }
        else if (rotebtnScript.BtnUP)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(90f, Vector3.right), 5f);
        }
        else if (rotebtnScript.BtnF)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(-90f, Vector3.right), 5f);
        }
        else if (rotebtnScript.BtnR)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(-90f, Vector3.up), 5f);
        }
    }
}

