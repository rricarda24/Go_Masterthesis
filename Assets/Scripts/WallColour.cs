using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WallColour : MonoBehaviour {
    public GameObject Parent;
    public GameObject Floor;
    public GameObject Ceiling;

    public int setColour;
    public int thisColour;
    

    public int selectedHue; //1 = red, 2 = blue

    public Material[] material;

    public Material[] hue1;
    public Material[] hue2;
    public Material matFloor;
    public Material matCeiling;

    Renderer rend;
    Renderer rendFloor;
    Renderer rendCeiling;


    public void ChangeColour()
    {
       // selectedHue = Condition.hue;

       //if(Condition.setHue == 1)
       // {

       // }

        for (int x = 0; x < Parent.transform.childCount; x++)
        {
            rend = Parent.transform.GetChild(x).GetComponent<Renderer>();
            rend.enabled = true;
            rend.sharedMaterial = material[setColour];           
        }
        
        Debug.Log("Color:" + rend.material);

        // set floor and ceiling to neutral colour
        rendFloor = Floor.GetComponent<Renderer>();
        rendFloor.enabled = true;
        rendFloor.sharedMaterial = matFloor;

        rendCeiling = Ceiling.GetComponent<Renderer>();
        rendCeiling.enabled = true;
        rendCeiling.sharedMaterial = matCeiling;

        //Debug.Log("Floor & Ceiling set to neutral.");
    }

    // Use this for initialization
    void Start()
    {
        ChangeColour();
        SetColour();
       

    }

    public void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            setColour = setColour+1;

            ChangeColour();
        }
    }

    public void SetColour()
    {
        //setColour = GameManager.GetCondition();
        Debug.Log("First colour: " + setColour);
    }
}
