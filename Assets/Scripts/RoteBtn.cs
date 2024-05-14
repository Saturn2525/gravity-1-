using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoteBtn : MonoBehaviour
{
    public bool BtnL = false;
    public bool BtnZP = false;
    public bool BtnF = false;
    public bool BtnUP = false;
    public bool BtnR = false;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BtnL"))
        {
            BtnL = true;
            BtnZP = false;
            BtnF = false;
            BtnUP = false;
            BtnR = false;
}
        if (collision.gameObject.CompareTag("BtnZP"))
        {
            BtnL = false;
            BtnZP = true;
            BtnF = false;
            BtnUP = false;
            BtnR = false;
        }
        if (collision.gameObject.CompareTag("BtnF"))
        {
            BtnL = false;
            BtnZP = false;
            BtnF = true;
            BtnUP = false;
            BtnR = false;
        }
        if (collision.gameObject.CompareTag("BtnUP"))
        {
            BtnL = false;
            BtnZP = false;
            BtnF = false;
            BtnUP = true;
            BtnR = false;
        }
        if (collision.gameObject.CompareTag("BtnR"))
        {
            BtnL = false;
            BtnZP = false;
            BtnF = false;
            BtnUP = false;
            BtnR = true;
        }
    }
}
