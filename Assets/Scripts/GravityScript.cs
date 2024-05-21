using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{
    [SerializeField] private float gravityScale;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float rayLength = 1;

    public Vector3 gravityDirection { get; private set; }

    public bool isFixCamera { get; private set; }
    public bool noChangeGravityWall { get; private set; }

    void Start()
    {
        gravityDirection = Vector3.down;
        Physics.gravity = gravityDirection * gravityScale;
    }

    void Update()
    {
        CastRay(Vector3.up);
        CastRay(Vector3.down);
        CastRay(Vector3.left);
        CastRay(Vector3.right);
        CastRay(Vector3.forward);
        CastRay(Vector3.back);

        Quaternion targetRotation = Quaternion.FromToRotation(transform.up, -gravityDirection);

        transform.rotation = targetRotation * transform.rotation;

        if (gravityDirection != Vector3.zero)
        {
            Physics.gravity = gravityDirection.normalized * gravityScale;
        }

        lastDistance = float.MaxValue;
    }

    float lastDistance = float.MaxValue;
    void CastRay(Vector3 direction)
    {
        Ray ray = new Ray(transform.position, direction);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayLength))
        {
            float distance = Vector3.Distance(hit.point, transform.position + _rigidbody.velocity);
            if (distance < lastDistance)
            {
                if (hit.collider.gameObject.CompareTag("noChangeGravityWall")) return;
                gravityDirection = direction;
                lastDistance = distance;
            }
        }

        // デバッグ用のRayをシーンビューに表示
        Debug.DrawRay(transform.position, direction * rayLength, Color.red);
    }
}
