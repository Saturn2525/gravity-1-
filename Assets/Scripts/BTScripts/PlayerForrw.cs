using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForrw : MonoBehaviour
{
    public Transform PlayerTransform;
    private Vector3 _cameraOffset;

    public float SmoothFactor = 0.5f;
    public bool LookAtPlayer = false;
    public bool RotateAroundPlayer = true;
    public float RotationSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _cameraOffset = transform.position - PlayerTransform.position;
    }
     void Update()
    {
        if (RotateAroundPlayer)
        {
            Quaternion camTurnAngle =
                Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationSpeed, Vector3.up);
            _cameraOffset = camTurnAngle * _cameraOffset;
        }

        Vector3 newPos = PlayerTransform.position + _cameraOffset;

       transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
        if (LookAtPlayer || RotateAroundPlayer)
            transform.LookAt(PlayerTransform);
    }
    // Update is called once per frame
   private void LateUpdate()
    {
        GravityScript gravityScript;
        GameObject obj = GameObject.Find("Player"); //Playerっていうオブジェクトを探す
        gravityScript = obj.GetComponent<GravityScript>(); //付いているスクリプトを取得

        if(gravityScript.gravityL)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.AngleAxis(90f, Vector3.forward) * transform.rotation, 1);
        }
        else if (gravityScript.gravityR)
        {

        }
        else if (gravityScript.gravityZP)
        {

        }
        else if (gravityScript.gravityZM)
        {

        }
        else 
        {
        
        }

    }
}
