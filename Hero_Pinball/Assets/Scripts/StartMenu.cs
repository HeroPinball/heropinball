
//Attach to main camera
using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour 
{

	public GUISkin custGUISkin;


	void OnGUI()
	{

		GUI.skin = custGUISkin;
		//Displays buttons
		if (GUI.Button (new Rect (Screen.width * 0.18f, Screen.height * 0.18f, 270, 85), "Play")) 
		{
			Application.LoadLevel(1);
		}

		GUI.Button (new Rect (Screen.width * 0.18f, Screen.height * 0.25f, 270, 85), "Instructions");

		GUI.Button (new Rect (Screen.width * 0.18f, Screen.height * 0.32f,270, 85), "High Scores");

	}

	

}
