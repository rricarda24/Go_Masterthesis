using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSerialMessage : MonoBehaviour {

    private SerialControl serialController;
    public string testMessage;

    void Start()
    {
        serialController = SerialControl.instance;
    }
    public void SendTestMessage()
    {
        serialController.WriteToPort(testMessage);
    }
}
