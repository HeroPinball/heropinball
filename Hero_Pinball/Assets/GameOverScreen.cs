using UnityEngine;
using System.Collections;

public class GameOverScreen : MonoBehaviour {

		
		public GUISkin custGUISkin;
		private GameObject scorekeeper;
		
	void Start(){		scorekeeper = GameObject.FindGameObjectWithTag("Scorekeeper");}
		
		void OnGUI()
		{
			
			GUI.skin = custGUISkin;
			//Displays buttons
			if (GUI.Button (new Rect (Screen.width * 0.5f - 115, Screen.height * 0.6f, 230, 85), "Main Menu")) 
			{
				scorekeeper.SendMessage("Start");
				Application.LoadLevel("StartMenu");
				
			}
			

			
		}
		
		
		

}