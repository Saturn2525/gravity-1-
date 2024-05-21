using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    private float speed = 9f;
    void Update()
    {
        JampScript jampScript = GetComponent<JampScript>();
        if (jampScript.isJumping == true)
        {
            speed = 6f;
        }
        if (jampScript.isJumping == false)
        {
            speed = 8f;
        }
        //垂直方向と水平方向の入力を取得し、それぞれの移動速度をかける。
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * Camera.main.transform.forward * Time.deltaTime;
        }
        // Sキー（後方移動）
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= speed * Camera.main.transform.forward * Time.deltaTime;
        }

        // Dキー（右移動）
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += speed * Camera.main.transform.right * Time.deltaTime;
        }

        // Aキー（左移動）
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= speed * Camera.main.transform.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("A");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DeathFloor"))
        {
            SceneManager.LoadScene("A");
        }
    }
}
