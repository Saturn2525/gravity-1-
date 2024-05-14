using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloorScript : MonoBehaviour
{
    private float speed=2.2f;
    private Rigidbody rb;
    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posZ = startPos.z + Mathf.PingPong(Time.time * speed, 5.5f);
        rb.MovePosition(new Vector3(startPos.x ,startPos.y, posZ));
    }
}
