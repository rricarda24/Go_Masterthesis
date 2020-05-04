using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonContinue : MonoBehaviour {

    public string nextScene;

    public void Continue()
    {
        SceneManager.LoadSceneAsync(nextScene);     
    }
}
