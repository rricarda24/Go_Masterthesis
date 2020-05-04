using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleCoroutineInteractions : MonoBehaviour
{

    public CoroutineCreator coroutineCreator;
    public bool startStop, pause;

    private bool hasStarted;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (startStop && !hasStarted)
        {
            hasStarted = true;
            coroutineCreator.StartCoroutines();
        }

        else if (!startStop && hasStarted)
        {
            hasStarted = false;
            coroutineCreator.StopCoroutines();
        }


        if (pause)
        {
            coroutineCreator.PauseCoroutines(true);
        }

        else coroutineCreator.PauseCoroutines(false);
    }
}
