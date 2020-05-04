using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LogCogTask : MonoBehaviour {

    public static float buttonTime;
    public static float reactionTime;

    private void Update()
    {
        ButtonPressed();
    }
    //log everytime something is instantiated (square or circle)

    //log everytime the trigger button is pushed 
    public void ButtonPressed()
    {
        if (Input.GetButtonDown("Fire1") || OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        // OVR Manager Script needed!
        // Fire1: Left Ctrl
        {
            buttonTime = Time.time;
            Debug.Log("Button pressed: " + buttonTime);

            if (GeneratePoint.isTarget == true)
            {
                reactionTime = buttonTime - GeneratePoint.timeInstantiating;
                Debug.Log("Target detected: " + reactionTime);

                string newLine = CreateCSV.ID + "," + SceneCount.sceneCount + ","
                    + buttonTime + "," + GeneratePoint.timeInstantiating + "," 
                    + GeneratePoint.isTarget + "," + reactionTime
                    + System.Environment.NewLine;

                StreamWriter writer = new StreamWriter(CreateCSV.pathCog, true);
                writer.Dispose();

                File.AppendAllText(CreateCSV.pathCog, newLine);
            }

            if (GeneratePoint.isTarget == false)
            {
                reactionTime = 999;
                Debug.Log("False positive.");

                string newLine = CreateCSV.ID + "," + SceneCount.sceneCount + ","
                    + buttonTime + "," + GeneratePoint.timeInstantiating + ","
                    + GeneratePoint.isTarget + "," + reactionTime
                    + System.Environment.NewLine;

                StreamWriter writer = new StreamWriter(CreateCSV.pathCog, true);
                writer.Dispose();

                File.AppendAllText(CreateCSV.pathCog, newLine);
            }            
        }
    }
}
