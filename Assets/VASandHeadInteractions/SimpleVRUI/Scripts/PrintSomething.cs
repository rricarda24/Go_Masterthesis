using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintSomething : MonoBehaviour {

	public Scrollbar m_scrollBar;

	public void OnButtonSelect(){
		Debug.Log ("this button was pressed");
	}
	
	public void OnSliderChange(){
		if(m_scrollBar != null)
			Debug.Log ("the selected value is " + m_scrollBar.value);
	}
}
