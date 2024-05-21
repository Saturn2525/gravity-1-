using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatecamera : MonoBehaviour
{
    // Start is called before the first frame update
    private float XAngle = 0;
    private float YAngle = 0;
    [SerializeField] private float AngleSpeed;
    [SerializeField] private float MaxAngle;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetAngle();

        Quaternion targetRotation = Quaternion.FromToRotation(transform.up, -Physics.gravity) * transform.rotation;
        Quaternion additionalRotation = Quaternion.Euler(0, XAngle, 0);
        Quaternion finalTargetRotation = targetRotation * additionalRotation;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, finalTargetRotation, 5);
        transform.Rotate(-Physics.gravity, XAngle * Time.deltaTime);
    }

    private void SetAngle()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            XAngle = AngleSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            XAngle = 0;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            XAngle = -AngleSpeed;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            XAngle = 0;
        }
    }

    private Quaternion GetAngle => Quaternion.AngleAxis(YAngle, transform.right);

}
