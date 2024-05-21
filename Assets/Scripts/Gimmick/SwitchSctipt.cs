using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSctipt : MonoBehaviour
{
    [SerializeField] private GameObject door;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Key"))
        {
            door.SetActive(false);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Key"))
        {
            door.SetActive(true);
        }
    }
}
