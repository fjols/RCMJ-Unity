using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	//buttons initializaton
	public Button start;
	public Button settings;
	public Button exit;

	// Use this for initialization
	void Start () {

		//getting button components
		start = start.GetComponent<Button> ();
		settings = settings.GetComponent<Button> ();
		exit = exit.GetComponent<Button> ();

	}

	//start game on click
	public void startGame(){

		SceneManager.LoadScene ("main");

	}

	//show settings menu (sound, brightness) on click
	public void SettingsMenu(){

		SceneManager.LoadScene ("Settings");
	}

	//exit game
	public void Exit(){
		
		Application.Quit ();

	}
}
