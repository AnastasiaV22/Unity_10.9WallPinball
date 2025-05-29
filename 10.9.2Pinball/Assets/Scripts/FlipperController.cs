using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    [SerializeField] HingeJoint joint;

    void Update()
    {
        var motor = joint.motor;
        
        if (Input.GetKey(KeyCode.Space))
        {
            motor.targetVelocity = -400;
            motor.force = 1000;
        }
        else
        {

            motor.targetVelocity = 300;
            motor.force = 200;
        }

        joint.motor = motor;
    }
}
