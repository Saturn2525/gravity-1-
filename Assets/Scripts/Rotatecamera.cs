using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatecamera : MonoBehaviour
{
    // Start is called before the first frame update
    private float XAngle = 0;
    private float YAngle = 0;
    [SerializeField] private float AngleSpeed;
    [SerializeField] private float MaxAngle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GravityScript gravityScript;
        GameObject obj = GameObject.Find("Player"); //Playerっていうオブジェクトを探す
        gravityScript = obj.GetComponent<GravityScript>(); //付いているスクリプトを取得
        SetAngle();
        if (gravityScript.gravityL)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(-90f, Vector3.forward)*GetAngle , 5f);
        }
        else if (gravityScript.gravityR)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(90f, Vector3.forward) * GetAngle, 5f);
        }
        else if (gravityScript.gravityZP)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(-90f, Vector3.right) * GetAngle, 5f);
        }
        else if (gravityScript.gravityZM)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(90f, Vector3.right) * GetAngle, 5f) ;
        }
        else if (gravityScript.gravityUP)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(180f, Vector3.forward) * GetAngle, 5f);
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(0, Vector3.forward) * GetAngle, 5f);
        }
    }

    private void SetAngle()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            XAngle += AngleSpeed * Time.deltaTime;
            if(XAngle >=MaxAngle)
              XAngle = MaxAngle; 
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            XAngle -= AngleSpeed * Time.deltaTime;
            if (XAngle <= -MaxAngle)
                XAngle = -MaxAngle;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            YAngle += AngleSpeed * Time.deltaTime;
            if (YAngle >= MaxAngle)
                YAngle = MaxAngle;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            YAngle -= AngleSpeed * Time.deltaTime;
            if (YAngle <= -MaxAngle)
                YAngle = -MaxAngle;
        }

    }

    private Quaternion GetAngle => Quaternion.AngleAxis(XAngle, Vector3.up)* Quaternion.AngleAxis(YAngle, Vector3.right);

}
