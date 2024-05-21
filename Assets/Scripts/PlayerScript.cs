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
        //���������Ɛ��������̓��͂��擾���A���ꂼ��̈ړ����x��������B
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * Camera.main.transform.forward * Time.deltaTime;
        }
        // S�L�[�i����ړ��j
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= speed * Camera.main.transform.forward * Time.deltaTime;
        }

        // D�L�[�i�E�ړ��j
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += speed * Camera.main.transform.right * Time.deltaTime;
        }

        // A�L�[�i���ړ��j
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
