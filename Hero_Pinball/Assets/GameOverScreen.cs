using UnityEngine;
using System.Collections;

public class GameOverScreen : MonoBehaviour {

		
		public GUISkin custGUISkin;
		
		void OnGUI()
		{
			
			GUI.skin = custGUISkin;
			//Displays buttons
			if (GUI.Button (new Rect (Screen.width * 0.5f - 115, Screen.height * 0.6f, 230, 85), "Main Menu")) 
			{
				Application.LoadLevel("StartMenu");
			}
			

			
		}
		
		
		

}