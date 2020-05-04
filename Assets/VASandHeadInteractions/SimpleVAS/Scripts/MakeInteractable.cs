using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeInteractable : MonoBehaviour {


	public void OnSelection(){
		this.GetComponent<Button> ().interactable = true;
	}
}
