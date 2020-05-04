 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWallColour : MonoBehaviour {

    public Material[] material;
    Renderer rend;

    public int whichColour;
    CreateCSV myCSV;
    
	// Use this for initialization
	void Start ()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0]; //uses 1st Material in the array
        //SetColour();
	}

    //public void Update ()
    //{
    //   if (Input.GetButtonDown("Jump"))
    //    {
    //        rend.sharedMaterial = material[3];
    //        Debug.Log("Changed.");
    //    } 
       
    //}

    //public void SetColour()
    //{
    //    whichColour = myCSV.cond;
    //    Debug.Log("First colour: " + whichColour);
    //}
	
}
