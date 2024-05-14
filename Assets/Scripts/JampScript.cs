using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JampScript : MonoBehaviour
{
    public float jumpPower;
    private Rigidbody rb;
    public bool isJumping = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        GravityScript gravityScript = GetComponent<GravityScript>();
        //ジャンプする入力
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            if (gravityScript.gravityL)
            {
                rb.velocity = Vector3.right * jumpPower;
            }
            else if (gravityScript.gravityR)
            {
                rb.velocity = Vector3.left * jumpPower;
            }
            else if (gravityScript.gravityUP)
            {
                rb.velocity = Vector3.down * jumpPower;
            }
            else if (gravityScript.gravityZP)
            {
                rb.velocity = Vector3.back* jumpPower;
            }
            else if (gravityScript.gravityZM)
            {
                rb.velocity = Vector3.forward * jumpPower;
            }
            else
            {
                rb.velocity = Vector3.up * jumpPower;
            }
            isJumping = true;
        }
    }
    //ジャンプしているか否か
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor")|| collision.gameObject.CompareTag("FloorL") ||
            collision.gameObject.CompareTag("FloorR") || collision.gameObject.CompareTag("FloorUP") || 
            collision.gameObject.CompareTag("FloorZP") || collision.gameObject.CompareTag("FloorZM"))
        {
            isJumping = false;
        }

    }
}
