using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour {

    public GameObject wheel1;
    public GameObject wheel2;
	
    public void SetSpeed(float speed)
    {

        //.motor.motorSpeed = speed;
        //WheelJoint2D joint1 = wheela.GetComponent<WheelJoint2D>();
        //joint1.motor.motorSpeed = speed;
        //wheel2.motor.motorSpeed = speed;

        WheelJoint2D wheelComponent = wheel1.GetComponent<WheelJoint2D>();
        JointMotor2D newMotor = wheelComponent.motor;
        newMotor.motorSpeed = speed;

        WheelJoint2D wheelComponent2 = wheel2.GetComponent<WheelJoint2D>();
        JointMotor2D newMotor2 = wheelComponent2.motor;
        newMotor2.motorSpeed = speed;

        wheelComponent.motor = newMotor;
        wheelComponent2.motor = newMotor2;
    }
	// Update is called once per frame
	
}
