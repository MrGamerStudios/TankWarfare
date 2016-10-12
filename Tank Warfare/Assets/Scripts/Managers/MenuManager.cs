using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public Button Play_Button;
	public Button Quit_Button;
	public Button Local_Multiplayer;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void Quit_Game () {

		Application.Quit ();
	}

	public void Main_Menu () {

		SceneManager.LoadScene (0);
	}

	public void LMultiplayer () {

		SceneManager.LoadScene (1);
	}
}