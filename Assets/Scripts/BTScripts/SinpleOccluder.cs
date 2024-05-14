using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinpleOccluder : MonoBehaviour
{
    public float m_transparency = 0.2f;
    public float m_opaque = 1f;

    private void OnTriggerEnter(Collider other)
    {
        Renderer r=other.gameObject.GetComponent<Renderer>();
        ChangeAlpha(r, m_transparency);

        ChangeAlpha(r, m_opaque);
    }
   
    void ChangeAlpha(Renderer renderer,float tergetAlpha)
    {
        if(renderer)
        {
            Material m = renderer.material;
            Color c = m.color;
            c.a = tergetAlpha;
            m.color = c;
        }
    }
}

