 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateCSV : MonoBehaviour {

    public InputField participantID;
    public static string ID;

    public InputField temperature;
    public static string temp;

    public Dropdown selectHandedness;
    public string handedness;
    public static int hand;

    public Dropdown selectCondition;
    public string condition;
    public static int cond;

    public Dropdown selectOrder;
    public string order;
    public static int ord;

    public InputField comPort;
    public static string comPortNr;

    public Toggle testRun;
    public static bool isTestRun;

    public static string path;
    public static string pathCog;
    public static string pathHead;


    public void GetID()
    {
        // Get the ID from the input field.
        ID = participantID.text;
        //Debug.Log("This participants ID is: " + ID);
    }

    public void GetTemperature()
    {
        temp = temperature.text;
    }

    public void GetHandedness()
    {
        handedness = selectHandedness.options[selectHandedness.value].text;
        //Debug.Log(handedness);

        if (handedness == "right-handed")
            hand = 0;
        else if (handedness == "left-handed")
            hand = 1;
        else
            hand = 2;
    }

    public void GetCondition()
    {
        condition = selectCondition.options[selectCondition.value].text;
        if (condition == "Condition 1 (r)")
            cond = 0; //blue
        else
            cond = 1; //red
    }

    public void GetOrder()
    {
        order = selectOrder.options[selectOrder.value].text;
        if (order == "Order 1")
            ord = 0;
        else if (order == "Order 2")
            ord = 1;
        else if (order == "Order 3")
            ord = 2;
        else
            ord = 3;
    }

    public void GetComPort()
    {
        comPortNr = comPort.text;
    }

    public void GetTestRun()
    {
        if (testRun.isOn) isTestRun = true;
        else isTestRun = false;
    }

    public void CreateFile()
    {
        //Debug.Log("Create file for ID " + ID);

        // New file path:
        string fileName = ID + ".csv";
        path = "Assets/CSV/" + fileName;
        Debug.Log("Pfad (origin): " + path);


        //Check if file already exists
        if (File.Exists(path))
        {
            Debug.Log("Attention! This ID already exists.");
            SceneManager.LoadSceneAsync("0.0_Intro");
        }

        else
        {
            Debug.Log("New file created: " + fileName);
            StreamWriter writer = new StreamWriter(path, true);
            writer.Dispose();

            string header = "Proband_ID" + "," + "Date" + "," + "Time" + "," + "Temperature" + "," 
                + "Handedness" + "," + "Condition" + "," + "Order" + "," + "ComPort" + "," 
                 + "ConditionNr" + "," + "SAM_arousal" + "," + "SAM_valence" + "," 
                 + "Presence" + "," + "Colour" + "ColourNr" + "," + "Ishihara_Result" + System.Environment.NewLine;

            File.AppendAllText(path, header);
        }
    } 
    
    public void CreateFileCognitiveTask()
    {
        // New file path:
        string fileCog = ID + "_cog" + ".csv";
        pathCog = "Assets/CSV/" + fileCog;
        Debug.Log("Pfad Cog: " + pathCog);

        StreamWriter writerCog = new StreamWriter(pathCog, true);
        writerCog.Dispose();

        string header = "Proband_ID" + "," + "ConditionNr" + ","
                    + "ButtonPressed" + "," + "TimeInstantiated" + "," 
                    + "isTarget" + "," + "ReactionTime" + System.Environment.NewLine;

        File.AppendAllText(pathCog, header);
    }

    public void CreateFileHeadTracking()
    {
        // New file path:
        string fileHead = ID + "_head" + ".csv";
        pathHead = "Assets/CSV/" + fileHead;
        Debug.Log("Pfad Head: " + pathHead);

        StreamWriter writerHead = new StreamWriter(pathHead, true);
        writerHead.Dispose();

        string header = "Proband_ID" + "," + "ConditionNr" + "," 
                    + "rotationAngle_x" + "," + "rotationAngle_y" + "," + "rotationAngle_z" + "," 
                    + "acceleration" + "," + "time" + System.Environment.NewLine;

        File.AppendAllText(pathHead, header);
    }
}

