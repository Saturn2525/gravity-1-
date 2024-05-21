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
        //ジャンプする入力
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = -Physics.gravity.normalized * jumpPower;
            isJumping = true;
        }
    }

    //ジャンプしているか否か
    private void OnCollisionEnter(Collision collision)
    {
        // if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("FloorL") ||
        //     collision.gameObject.CompareTag("FloorR") || collision.gameObject.CompareTag("FloorUP") ||
        //     collision.gameObject.CompareTag("FloorZP") || collision.gameObject.CompareTag("FloorZM"))
        // {
        //     isJumping = false;
        // }

        isJumping = false;

    }
}
