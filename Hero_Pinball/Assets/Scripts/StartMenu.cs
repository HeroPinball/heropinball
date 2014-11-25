
//Attach to main camera
using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour 
{

	public GUISkin custGUISkin;
	public GameObject scorekeeper;
	
	void Start()
	{
		scorekeeper = GameObject.FindGameObjectWithTag("Scorekeeper");
	}
	
	void OnGUI()
	{

		GUI.skin = custGUISkin;
		//Displays buttons
		if (GUI.Button (new Rect (Screen.width * 0.15f, Screen.height * 0.18f, 270, 75), "Play")) 
		{
	
			scorekeeper.SendMessage("NextLevel");
		}

		if(GUI.Button (new Rect (Screen.width * 0.15f, Screen.height * 0.28f, 270, 75), "Instructions"))
		{
			Application.LoadLevel("Instructions");
		}
		
		
		if(GUI.Button (new Rect (Screen.width * 0.15f, Screen.height * 0.38f,270, 75), "High Scores"))

		{
			Application.LoadLevel("HighScores");
		}

	}

	

}
