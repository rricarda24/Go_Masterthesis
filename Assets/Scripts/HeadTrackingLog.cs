using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using System.IO;

public class HeadTrackingLog : MonoBehaviour
{

    public float logRate;
    public Transform viewForHeadTracking; //Transform not Camera

    private float lastRotationMagnitude;
    private float currentRotationAcceleration;
    private float timeAtStart;

    private Vector3 cameraRotation;

    // Use this for initialization
    void Start() {

        InvokeRepeating("FastLogger", 0f, logRate); //1.5 instead of 0.0
        timeAtStart = Time.fixedDeltaTime;

    }

    // Update is called once per frame
    void Update() {
            cameraRotation = viewForHeadTracking.rotation.eulerAngles;
            Vector3 orientationVector = viewForHeadTracking.transform.rotation.eulerAngles;
            currentRotationAcceleration = orientationVector.magnitude - lastRotationMagnitude;
            lastRotationMagnitude = orientationVector.magnitude;
    }

    void FastLogger() { 
        //Debug.Log("at time: " + Time.fixedUnscaledTime + " the head acceleration is " + currentRotationAcceleration + " the head orientation in x is " + cameraRotation.x.ToString());
        
        //Manually writing to file istead of WriteToFile
        
        string tracking = CreateCSV.ID + "," + SceneCount.sceneCount + "," 
            + cameraRotation.x.ToString() + "," + cameraRotation.y.ToString() + "," + cameraRotation.z.ToString() + "," 
            + currentRotationAcceleration.ToString() + "," + (Time.fixedUnscaledTime-timeAtStart).ToString() + System.Environment.NewLine;

        StreamWriter writer = new StreamWriter(CreateCSV.pathHead, true);
        writer.Dispose();

        File.AppendAllText(CreateCSV.pathHead, tracking);     
    }


}
