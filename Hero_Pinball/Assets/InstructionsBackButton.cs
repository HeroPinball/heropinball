using UnityEngine;
using System.Collections;

public class InstructionsBackButton : MonoBehaviour {

	public GUISkin custGUISkin;
	
	
	void OnGUI()
	{
		
		GUI.skin = custGUISkin;
		//Displays buttons
		if (GUI.Button (new Rect (Screen.width * 0.20f, Screen.height * 0.80f, 110, 75), "Back")) 
		{
			Application.LoadLevel("StartMenu");
		}
		

		
	}
	
}
