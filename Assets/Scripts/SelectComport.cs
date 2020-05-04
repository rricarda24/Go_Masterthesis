using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectComport : MonoBehaviour {

    public static string selectedPort;
    public Text inputFieldPort;

    public void OnStart()
    {
        selectedPort = inputFieldPort.text;
    }
}
