using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VASSlider : MonoBehaviour {
    public Scrollbar VAS;
    public Button OK;

    public static float presenceScore;

    public void SliderChanged()
    {
        presenceScore = Mathf.RoundToInt(VAS.value * 100); //0 - 100
        //Debug.Log(presenceScore);

        OK.interactable = true;     
    }
}
