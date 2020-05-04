using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineCreator : MonoBehaviour
{

    SerialControl serialController;
    public bool startOnLoad, pause;

    public List<float> coroutineTime;
    public string[] messages;

    private int itemCounter;



    void Start()
    {
        serialController = GetComponent<SerialControl>();   //loads the SerialControl script from this gameObject into serialController.

        if (startOnLoad)
            StartCoroutines();
    }

    //is called from elsewhere to start audio coroutines, one for each item in the list of times, which should match the number of audios.
    public void StartCoroutines()
    {

        Debug.Log("coroutine creator has started");
        foreach (var item in coroutineTime)
        {
            //StartCoroutine (createCoroutine (itemCounter, item));
            StartCoroutine(createPausableCoroutine(itemCounter, item));
            itemCounter++;
        }

    }

    //is called from elsewhere to stop audio coroutines
    public void StopCoroutines()
    {
        StopAllCoroutines();
    }

    public void PauseCoroutines(bool pauser)
    {
        if (pauser) pause = true;
        else pause = false;
    }

    /*
	public IEnumerator createCoroutine(int messageIndex, float time) {
		yield return new WaitForFixedTime (time);
		serialController.WriteToPort(messages[messageIndex]);
		Debug.Log ("Sent message " + messages [messageIndex]);
	}*/


    public IEnumerator createPausableCoroutine(int messageIndex, float time)
    {

        float timeCount = 0;

        while (timeCount < time)
        {
            if (!pause)
                timeCount += Time.fixedDeltaTime;
            yield return null;
        }

        yield return null;
        serialController.WriteToPort(messages[messageIndex]);
        Debug.Log("Sent message " + messages[messageIndex]);
    }

}
