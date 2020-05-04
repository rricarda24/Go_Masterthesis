using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour {

    public Button OK;
	// Use this for initialization
	void Start ()
    {

        OK.interactable = false;
		
	}
	
	
}
