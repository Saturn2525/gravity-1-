using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_2D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ButtonScript buttonScript;
        GameObject obj = GameObject.Find("Player"); //Playerっていうオブジェクトを探す
        buttonScript = obj.GetComponent<ButtonScript>();

        if (buttonScript.btun_2 == true)
        {
            Destroy(this.gameObject);
        }
    }
}

