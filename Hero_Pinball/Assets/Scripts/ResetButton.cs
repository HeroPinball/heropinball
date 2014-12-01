using UnityEngine;
using System.Collections;

public class ResetButton : MonoBehaviour {

	public GUISkin custGUISkin;
	
	
	void OnGUI()
	{
		
		GUI.skin = custGUISkin;
		//Displays buttons
		if (GUI.Button (new Rect (Screen.width * 0.60f, Screen.height * 0.80f, 130, 75), "Reset")) 
		{
			PlayerPrefs.DeleteAll();
			GameObject.Find("HighScores").SendMessage("Start");
		}
		
		
		
	}
}
