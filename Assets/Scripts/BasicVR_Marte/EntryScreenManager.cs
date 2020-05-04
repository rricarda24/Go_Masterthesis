//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI; 
//using UnityEngine.SceneManagement;
//using UnityEngine.XR;	
//using System.IO.Ports;

//public class EntryScreenManager : MonoBehaviour {

//	public InputField nameField, ageField, enteredDurationShort, enteredDurationLong;

//	public Text genderField, handednessField;

//	public Dropdown serialDropdown;

//	public Button nextButton;
//	public Toggle arduinoOn;

//	//private string participantName, age;
//	public static string participantName, age;

//	public static bool isFemale, arduinoTrackingIsOn;

//	public static int conditionDurationShort, conditionDurationLong, portIndex;//conditionDurationLong, 

//	public CsvWrite csvWriter;

//	// Use this for initialization
//	void Start () {

//		InputTracking.disablePositionalTracking = true;
//		nextButton.interactable = false;
//		nextButton.onClick.AddListener (OnNextButton);

//		setSerialDropDownOptions ();
//		serialDropdown.interactable = false;
//	}
	
//	// Update is called once per frame
//	void Update () {

//		if (participantName != null && age != null)
//			nextButton.interactable = true;

//	}

//	public void userName() {
//		participantName = nameField.text;

//	}

//	public void userAge() {
//		age = ageField.text;
//	}
		

//	public void OnArduinoTracking() {

//		serialDropdown.interactable = arduinoOn.isOn;
//		arduinoTrackingIsOn = arduinoOn.isOn;

//	}
		


//	public void setSerialDropDownOptions () {

//		string[] ports = SerialPort.GetPortNames();
//		serialDropdown.options.Clear ();

//		foreach (string c in ports) {
//			serialDropdown.options.Add (new Dropdown.OptionData () { text = c }); 
//		}
//	}

//	public void OnNextButton () {


//		if (genderField.text == "Female")
//			isFemale = true;
		
//		else if (genderField.text != "Female")
//			isFemale = false;

//		portIndex = serialDropdown.value; //(serialDropdown.value);
//		conditionDurationShort = int.Parse(enteredDurationShort.text);
//		conditionDurationLong = conditionDurationShort;

//		//conditionDurationLong = int.Parse(enteredDuration.text);

//		CsvWrite.subjectID = participantName;
//		CsvWrite.age = age;

//		CsvWrite.gender = genderField.text;
//		CsvWrite.handedness = handednessField.text;


//		csvWriter.GetComponent<CsvWrite>().onParticipantDataEntered();

//		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	
//	}

//}
