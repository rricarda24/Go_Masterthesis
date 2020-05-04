using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Intro : MonoBehaviour {

    public Button start;
    public string nextScene;

    public void LoadNextScene()
    {
        SceneManager.LoadSceneAsync(nextScene);
        Debug.Log("Start experiment.");
    }

}
