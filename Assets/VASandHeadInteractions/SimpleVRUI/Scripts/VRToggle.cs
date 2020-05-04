using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRStandardAssets.Utils;
using UnityEngine.UI;
using VRStandardAssets.Menu;

// This script is for loading scenes from the main menu.
// Each 'button' will be a rendering showing the scene
// that will be loaded and use the SelectionRadial.
public class VRToggle: MonoBehaviour {
	public event Action<VRButton> OnButtonSelected;                   // This event is triggered when the selection of the button has finished.

	public GameObject VRInteractiveCamera;

	//[SerializeField] private VRCameraFade m_CameraFade;                 // This fades the scene out when a new scene is about to be loaded.
	//[SerializeField] private SelectionRadial m_SelectionRadial;         // This controls when the selection is complete.
	//[SerializeField] private VRInteractiveItem m_InteractiveItem;       // The interactive item for where the user should click to load the level.

	private VRCameraFade m_CameraFade;
	private SelectionRadial m_SelectionRadial;
	private VRInteractiveItem m_InteractiveItem;

	private Toggle attachedToggle;
	public float gazeTimeForSelection;

	public bool fadeOutOnSelect, fadeInOnSelect;

	private float elapsedSinceGazed,timeAtGaze;

	private bool m_GazeOver;                                            // Whether the user is looking at the VRInteractiveItem currently.


	private void OnEnable () {

		attachedToggle = GetComponent<Toggle> ();	

		if(this.GetComponent<VRInteractiveItem>() != null) m_InteractiveItem = this.GetComponent<VRInteractiveItem> ();

		else {
			this.gameObject.AddComponent (typeof(VRInteractiveItem));
			Debug.Log ("Attaching VR Interactive Script to this GameObject, it's required");
			m_InteractiveItem = this.GetComponent<VRInteractiveItem> ();
		}

		if(this.GetComponent<BoxCollider>() == null) {
			this.gameObject.AddComponent (typeof(BoxCollider));
			GetComponent<BoxCollider> ().size = new Vector3(this.GetComponent<RectTransform> ().rect.width, this.GetComponent<RectTransform> ().rect.height, 1);
			Debug.Log ("Attaching Box collider to this GameObject, it's required");
		}

		if (VRInteractiveCamera.GetComponent<VRCameraFade> () != null)	m_CameraFade = VRInteractiveCamera.GetComponent<VRCameraFade> ();
		else Debug.Log ("No VRCameraFade Script attached to the VR Interactive Camera, it's required");

		if(VRInteractiveCamera.GetComponent<SelectionRadial>() != null) m_SelectionRadial = VRInteractiveCamera.GetComponent<SelectionRadial> ();
		else Debug.Log ("No SelectionRadial Script attached to the VR Interactive Camera, it's required");

		if (gazeTimeForSelection == 0) gazeTimeForSelection = 1;

		m_InteractiveItem.OnOver += HandleOver;
		m_InteractiveItem.OnOut += HandleOut;
		m_SelectionRadial.OnSelectionComplete += HandleSelectionComplete;

	}

	void Update () {

		
		if (m_GazeOver && attachedToggle.IsInteractable()) 	elapsedSinceGazed = (Time.realtimeSinceStartup - timeAtGaze);

		else if (!m_GazeOver) elapsedSinceGazed = 0;

		if (elapsedSinceGazed >= gazeTimeForSelection) {
			attachedToggle.isOn = true;// onClick.Invoke (); //"clicks" the button
			//attachedToggle.interactable = false;
			//if (m_CameraFade != null) StartCoroutine (ActivateFade());
			elapsedSinceGazed = 0; //restart time count
			m_GazeOver = false;

		}
	}	


	private void OnDisable () {
		m_InteractiveItem.OnOver -= HandleOver;
		m_InteractiveItem.OnOut -= HandleOut;
		m_SelectionRadial.OnSelectionComplete -= HandleSelectionComplete;

	}


	private void HandleOver() {
		// When the user looks at the rendering of the scene, show the radial.
		if (attachedToggle.interactable == true) {
			timeAtGaze = Time.realtimeSinceStartup;
			m_SelectionRadial.Show();
			m_GazeOver = true;
		}
	}


	private void HandleOut()
	{
		// When the user looks away from the rendering of the scene, hide the radial.
		m_SelectionRadial.Hide();

		m_GazeOver = false;
		elapsedSinceGazed = 0;
	}


	private void HandleSelectionComplete() {

	}

	private IEnumerator ActivateFade() {
		// If the camera is already fading, ignore.
		if (m_CameraFade.IsFading)
			yield break;

		if(fadeOutOnSelect) yield return StartCoroutine(m_CameraFade.BeginFadeOut(true));
		if(fadeInOnSelect) yield return StartCoroutine (m_CameraFade.BeginFadeIn (true));

	}
}