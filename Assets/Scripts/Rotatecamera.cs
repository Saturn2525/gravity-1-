using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatecamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GravityScript gravityScript;
        GameObject obj = GameObject.Find("Player"); //Player���Ă����I�u�W�F�N�g��T��
        gravityScript = obj.GetComponent<GravityScript>(); //�t���Ă���X�N���v�g���擾

        if (gravityScript.gravityL)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(-90f, Vector3.forward), 5f);
        }
        else if (gravityScript.gravityR)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(90f, Vector3.forward), 5f);
        }
        else if (gravityScript.gravityZP)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(-90f, Vector3.right), 5f);
        }
        else if (gravityScript.gravityZM)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(90f, Vector3.right), 5f);
        }
        else if (gravityScript.gravityUP)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(180f, Vector3.forward), 5f);
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(0, Vector3.forward), 5f);
        }
    }
}
