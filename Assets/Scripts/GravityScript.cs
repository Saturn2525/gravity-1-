using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{

    private Vector3 localGravityL = new Vector3(-20f, 0, 0);
    private Vector3 localGravityR = new Vector3(20f, 0, 0);
    private Vector3 localGravityUP = new Vector3(0, 20f, 0);
    private Vector3 localGravityDOWN = new Vector3(0, -20f, 0);
    private Vector3 localGravityZP = new Vector3(0, 0, 20f);
    private Vector3 localGravityZM = new Vector3(0, 0, -20f);
    public bool gravityL = false;
    public bool gravityR = false;
    public bool gravityUP = false;
    public bool gravityZP = false;
    public bool gravityZM = false;

    void Start()
    {
        Physics.gravity = localGravityDOWN;
    }

    void Update()
    {
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Floor"))
        {
            Physics.gravity = localGravityDOWN;
            transform.rotation = Quaternion.AngleAxis(0, new Vector3(0, 0, 1));
            gravityL = false;
            gravityR = false;
            gravityUP = false;
            gravityZP = false;
            gravityZM = false;
        }
         if (collision.gameObject.CompareTag("FloorL"))
        {
            Physics.gravity = localGravityL;
           transform.rotation = Quaternion.AngleAxis(-90, new Vector3(0, 0, 1)) ;
            gravityL = true;
            gravityR = false;
            gravityUP = false;
            gravityZP = false;
            gravityZM = false;
        }
         if (collision.gameObject.CompareTag("FloorR"))
        {
            Physics.gravity = localGravityR;
            transform.rotation = Quaternion.AngleAxis(90, new Vector3(0, 0, 1));
            gravityL = false;
            gravityR = true;
            gravityUP = false;
            gravityZP = false;
            gravityZM = false;
        }
         if (collision.gameObject.CompareTag("FloorUP"))
        {
            Physics.gravity = localGravityUP;
            transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 0, 1));
            gravityL = false;
            gravityR = false;
            gravityUP = true;
            gravityZP = false;
            gravityZM = false;
        }

         if (collision.gameObject.CompareTag("FloorZP"))
        {
            Physics.gravity = localGravityZP;
            transform.rotation = Quaternion.AngleAxis(-90, new Vector3(1, 0, 0));
            gravityL = false;
            gravityR = false;
            gravityUP = false;
            gravityZP = true;
            gravityZM = false;
        }
         if (collision.gameObject.CompareTag("FloorZM"))
        {
            Physics.gravity = localGravityZM;
            transform.rotation = Quaternion.AngleAxis(90, new Vector3(1, 0, 0));
            gravityL = false;
            gravityR = false;
            gravityUP = false;
            gravityZP = false;
            gravityZM = true;
        }
    }
}
