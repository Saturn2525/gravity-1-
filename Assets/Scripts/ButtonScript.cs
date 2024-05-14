using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public bool btun_1= false;
    public bool btun_2= false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {

       if(collision.gameObject.name == "Button_1")
        {
            btun_1 = true;
        }

        else if (collision.gameObject.name == "Button_2")
        {
            btun_2 = true;
        }

    }
}
