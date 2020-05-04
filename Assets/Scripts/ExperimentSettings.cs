using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SimpleVAS;

public class ExperimentSettings : MonoBehaviour {

	public Text input_id, input_age;
	public Dropdown input_group, input_gender, input_handedness, input_order;
	public Button nextButton;

	public static string id, age, group, gender, handedness;
	public static bool selectedOrder;

	private bool useFemaleAvatar;

	// Use this for initialization
	void Start () {
		nextButton.interactable = false;
	}

	// Update is called once per frame
	void Update () {

		//Debug.Log (input_order.value);

		if (input_id.text != "" && input_age.text != "")
			nextButton.interactable = true;
	}

	public void OnNextButton() {
		id = input_id.text;
		age = input_age.text;

		group = input_group.options[input_group.value].text;
		gender = input_gender.options[input_gender.value].text;
		handedness = input_handedness.options[input_handedness.value].text;

		if(input_order.value == 0) selectedOrder = false;
		else selectedOrder = true;


		//This was implemented to integrate the settings from the intro scene with the scripts that depend on BasicDataConfigurations from the SimpleVAS package.
		BasicDataConfigurations.age = age;
		BasicDataConfigurations.ID = id;
		BasicDataConfigurations.handedness = handedness;
		BasicDataConfigurations.gender = gender;



		//Debug.Log (BasicDataConfigurations.age + BasicDataConfigurations.ID + BasicDataConfigurations.handedness + BasicDataConfigurations.gender);

		SceneManager.LoadScene("WordList-pre");

		/*
		 if (group == "Experimental") {
		 if (gender == "Female") SceneManager.LoadScene ("Male");
		  else SceneManager.LoadScene ("Female");
		 }

		 else  if (group == "Control") {
		 	if (gender == "Female")	SceneManager.LoadScene ("Female");
		 	else SceneManager.LoadScene ("Male");
		 }
		 */

	}


}
