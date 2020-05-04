using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SimpleVAS
{
public class ConditionDictionary : MonoBehaviour {

	public string condition1, condition2, condition3;
	public Text conditionOrder;
	private string inputOrder;

	public static string[] selectedOrder;

	// Use this for initialization
	void Start () {
		//string[] items = conditionOrder.text.Split(' ');
	}

	public void OnNextButtonPressed () {

		selectedOrder = conditionOrder.text.Split(' ');

		for (int i = 0; i < selectedOrder.Length; i++) {
			if (selectedOrder [i] == "1") selectedOrder[i] = condition1;
			if (selectedOrder [i] == "2") selectedOrder[i] = condition2;
			if (selectedOrder [i] == "3") selectedOrder[i] = condition3;
		}

		//Debug.Log ("the first condition is " + selectedOrder[0] + " the second condition is " + selectedOrder[1] + " and the last one is " + selectedOrder[2]);

	}
}

}