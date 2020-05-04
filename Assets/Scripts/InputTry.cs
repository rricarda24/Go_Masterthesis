using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTry : MonoBehaviour {

    public Transform touchL;
    public Transform touchR;
    //public Transform touch;

    public bool inputA;
    public bool inputB;

	
	// Update is called once per frame
	void Update ()
    {
        touchL.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        touchR.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        //touch.localPosition = OVRInput.GetLocalControllerPosition(OVRInput.Controller.Touch);

        touchL.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
        touchR.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);
        //touch.localRotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.Touch);

        inputA = OVRInput.Get(OVRInput.RawButton.A);

        // track controllers
	}
}
