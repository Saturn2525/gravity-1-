using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotCollider : MonoBehaviour
{
    [SerializeField] Transform m_start;
    [SerializeField] Transform m_end;

    void Start()
    {

    }

    void Update()
    {
        if(m_start && m_end)
        {
            Vector3 pivotPosition = (m_end.position + m_start.position) / 2;
            transform.position = pivotPosition;
            Vector3 dir = m_end.position - transform.position;
            transform.forward = dir;
            BoxCollider col = GetComponent<BoxCollider>();
            float distance =Vector3.Distance(m_start.position, m_end.position);
            col.size = new Vector3(col.size.x, col.size.y, distance);
        }
    }
}
