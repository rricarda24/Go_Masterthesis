using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedToggle : MonoBehaviour {

	public ToggleGroup toggleGroup;
	public static int activeToggle;

	private int toggleIndex;


	public void OnSelection() {

		toggleIndex = -1;

		foreach (var item in toggleGroup.GetComponentsInChildren<Toggle>()) { //This way its possible to add more selections if needed.

			toggleIndex++;

			if (item.isOn == true) {
				//activeToggle = toggleIndex;
				activeToggle = 1-toggleIndex;//inverts values so that yes = 1, no = 0;
			}
		}

	}


}
