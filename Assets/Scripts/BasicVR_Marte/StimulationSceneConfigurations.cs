//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.XR;

//public class StimulationSceneConfigurations : MonoBehaviour {

//	public GameObject femaleAvatar;
//	public GameObject maleAvatar;
//	public bool changeSceneAtDuration;
//	public float setDuration;
//	public float timeAtSceneLoad;
//	public string keyToChangeScene;

//	public static string currentCondition;

//	private float reminderTime;

//	private float duration;
//	//public static int delayOrOwnership; //delay = 1, ownership = 2
//	public static int trialNumber;
//	public bool isExplorationScene, useLikert;

//	// Use this for initialization

//	void Awake () {
//		timeAtSceneLoad = Time.fixedUnscaledTime;
//	}

//	void Start () {


//		if (keyToChangeScene == null) keyToChangeScene = "space";

//		currentCondition = SceneManager.GetActiveScene ().name; //not in use at the moment

//		if (EntryScreenManager.conditionDurationShort != 0) {
//			if (trialNumber < 2)
//				duration = EntryScreenManager.conditionDurationShort;
//			else
//				duration = EntryScreenManager.conditionDurationLong;

//			reminderTime = duration - 30f;
//			Debug.Log ("reminder time " + reminderTime);
//			/*
//			Debug.Log (duration + " the short typed is : " + EntryScreenManager.conditionDurationShort + " the long typed is : " + EntryScreenManager.conditionDurationLong);
//			Debug.Log ("the current trial is " + trialNumber);*/

//			StartCoroutine ("playSoundAtTime");
//		} 

//		else {
//			duration = setDuration;
//			reminderTime = 0;
//		}
	
//		GenderSelection ();

//	}

//	void GenderSelection () {
		
//		if (femaleAvatar != null && maleAvatar != null) {
			
//			if (EntryScreenManager.isFemale) {
//				femaleAvatar.SetActive (true);
//				maleAvatar.SetActive (false);
//			} 

//			else if (!EntryScreenManager.isFemale) {
//				femaleAvatar.SetActive (false);
//				maleAvatar.SetActive (true);
//			}
//		}

//	}
	
//	// Update is called once per frame
//	void Update () {

//		//Destroy (this) ;//Use this in the conditional if a DontDestroyOnLoad is somewhere.
			
//		if (changeSceneAtDuration) {
//			if (trialNumber < 2) {
//				if ((Time.fixedUnscaledTime - timeAtSceneLoad) >= duration) {
//					SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1); //should ideally be improved to fixed time.
//					trialNumber = trialNumber + 1;
//				}
//			}

//			else if (trialNumber == 2) {
//				if ((Time.fixedUnscaledTime - timeAtSceneLoad) >= duration) {
//					SceneManager.LoadScene ("03a - Instructions - experiment"); 
//					trialNumber = trialNumber + 1;
//					}
//				}

//			else if (trialNumber == 3) {
//					if ((Time.fixedUnscaledTime - timeAtSceneLoad) >= duration) {
//						SceneManager.LoadScene ("06 - Thank you"); 
//						trialNumber = trialNumber + 1;
//					}
//				}

//		}

//		if (!isExplorationScene) {
//			if (!changeSceneAtDuration) {
				
//				if (Input.GetKeyDown (keyToChangeScene)) {
//					//delayOrOwnership = Random.Range (1, 3); //random between 1 and i-1
//					trialNumber = trialNumber + 1;

//					//if (delayOrOwnership == 1)
//					if (useLikert)
//						SceneManager.LoadScene ("05 - Likert");
//					//if (delayOrOwnership == 2)
//					if (!useLikert)
//						SceneManager.LoadScene ("04 - VAS");
//				}
//			}
//		} 

//		else {
//			if (Input.GetKeyDown (keyToChangeScene)) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//		}

//	}

//	public IEnumerator playSoundAtTime () {

//		//for testing
//		//yield return new WaitForFixedTime (3f);
//		yield return new WaitForFixedTime (reminderTime);
//		//OscSoundPlayer.startSound = true;
//	}
		
		
//}
