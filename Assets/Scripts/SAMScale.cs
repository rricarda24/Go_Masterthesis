using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SAMScale : MonoBehaviour {

    public Toggle toggle1;
    public Toggle toggle2;
    public Toggle toggle3;
    public Toggle toggle4;
    public Toggle toggle5;
    public Toggle toggle6;
    public Toggle toggle7;
    public Toggle toggle8;
    public Toggle toggle9;

    public static int scoreSAMArousal;
    public static int scoreSAMValence;

    public Button OK;

    public void OnChangeValueArousal()
    {

        if(toggle1.isOn)
        {
            scoreSAMArousal = 1;
            Debug.Log(scoreSAMArousal);
            OK.interactable = true;
        }
        else if (toggle2.isOn)
        {
            scoreSAMArousal = 2;
            Debug.Log(scoreSAMArousal);
            OK.interactable = true;
        }

        else if (toggle3.isOn)
        {
            scoreSAMArousal = 3;
            Debug.Log(scoreSAMArousal);
            OK.interactable = true;
        }
        else if (toggle4.isOn)
        {
            scoreSAMArousal = 4;
            Debug.Log(scoreSAMArousal);
            OK.interactable = true;
        }
        else if (toggle5.isOn)
        {
            scoreSAMArousal = 5;
            Debug.Log(scoreSAMArousal);
            OK.interactable = true;
        }
        else if (toggle6.isOn)
        {
            scoreSAMArousal = 6;
            Debug.Log(scoreSAMArousal);
            OK.interactable = true;
        }
        else if (toggle7.isOn)
        {
            scoreSAMArousal = 7;
            Debug.Log(scoreSAMArousal);
            OK.interactable = true;
        }
        else if (toggle8.isOn)
        {
            scoreSAMArousal = 8;
            Debug.Log(scoreSAMArousal);
            OK.interactable = true;
        }
        else if (toggle9.isOn)
        {
            scoreSAMArousal = 9;
            Debug.Log(scoreSAMArousal);
            OK.interactable = true;
        }
    }

    public void OnChangeValueValence()
    {

        if (toggle1.isOn)
        {
            scoreSAMValence = 1;
            Debug.Log(scoreSAMValence);
            OK.interactable = true;
        }
        else if (toggle2.isOn)
        {
            scoreSAMValence = 2;
            Debug.Log(scoreSAMValence);
            OK.interactable = true;
        }

        else if (toggle3.isOn)
        {
            scoreSAMValence = 3;
            Debug.Log(scoreSAMValence);
            OK.interactable = true;
        }
        else if (toggle4.isOn)
        {
            scoreSAMValence = 4;
            Debug.Log(scoreSAMValence);
            OK.interactable = true;
        }
        else if (toggle5.isOn)
        {
            scoreSAMValence = 5;
            Debug.Log(scoreSAMValence);
            OK.interactable = true;
        }
        else if (toggle6.isOn)
        {
            scoreSAMValence = 6;
            Debug.Log(scoreSAMValence);
            OK.interactable = true;
        }
        else if (toggle7.isOn)
        {
            scoreSAMValence = 7;
            Debug.Log(scoreSAMValence);
            OK.interactable = true;
        }
        else if (toggle8.isOn)
        {
            scoreSAMValence = 8;
            Debug.Log(scoreSAMValence);
            OK.interactable = true;
        }
        else if (toggle9.isOn)
        {
            scoreSAMValence = 9;
            Debug.Log(scoreSAMValence);
            OK.interactable = true;
        }
    }
}
