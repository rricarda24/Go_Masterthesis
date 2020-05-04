using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public string nextScene;
    public float duration_seconds;

    public string messageOnStart;
    public SerialControl serialController;

    float timer;

    void Awake()
    {
        serialController = SerialControl.instance;
    }

    // Use this for initialization
    void Start()
    {
        serialController.WriteToPort(messageOnStart);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeToNextScene();
    }

    public void ChangeToNextScene()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer > duration_seconds)
        {
            //serialController.WriteToPort(messageOnEnd);
            SceneManager.LoadSceneAsync(nextScene);
        }
    }
}
