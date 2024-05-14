using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovefloorY : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 2.2f;
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
        float posY = startPos.y + Mathf.PingPong(Time.time * speed, 5.5f);
        rb.MovePosition(new Vector3(startPos.x, posY, startPos.z));
    }
}
