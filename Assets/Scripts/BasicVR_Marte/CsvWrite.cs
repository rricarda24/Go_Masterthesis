//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class CsvWrite : MonoBehaviour {

//	public static string subjectID, age, gender, handedness, questionID, answerValue;

//	private string instructionsMessage;
//	private string condition, trial;

//	// Use this for initialization
//	void Start () {
//		condition = ConditionOrder.currentCondition;
//		trial = StimulationSceneConfigurations.trialNumber.ToString();
//	}
	
//	// Update is called once per frame
//	void Update () {
		
//	}

//	public void onNextButtonPressed(){
		
//		WriteToFile (subjectID, age, gender, handedness, condition, trial, questionID, answerValue);

//	}

//	public void onParticipantDataEntered(){

//		WriteToFile ("subject ID", "age", "gender", "handedness", "condition", "trial", "question ID", "value");	
//	}


//	void WriteToFile(string a, string b, string c, string d, string e, string f, string g, string h){

//		string stringLine =  a + "," + b + "," + c + "," + d + "," + e + "," + f + "," + g + "," + h;

//		System.IO.StreamWriter file = new System.IO.StreamWriter("./Logs/" + subjectID + "_log.csv", true);
//		file.WriteLine(stringLine);
//		file.Close();	
//	}
//}
