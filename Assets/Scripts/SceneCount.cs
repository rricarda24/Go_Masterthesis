using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCount : MonoBehaviour {

    public static int sceneCount = 0;

    public void IncreaseCount()
    {
        sceneCount = sceneCount + 1;
    }
}
