using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;


public class TestToggle : MonoBehaviour {

    public Toggle testToggle;
    public Button start;

    bool buttonDown;

    public void ActivateToggle()
    {
        if (Input.GetButtonDown("Fire1") || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)) // OVR Manager Script needed!
        {
            testToggle.isOn = true;
            start.interactable = true;
        }

    }

    private void Start()
    {
        ActivateToggle();
    }
    private void Update()
    {
        ActivateToggle();
    }
}
