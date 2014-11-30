using UnityEngine;
using System.Collections;

public class HighScoreDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		string scores;
		scores = "";
		for (int i = 9; i >= 0; i--)
		{
			scores += ""+  PlayerPrefs.GetInt("Score"+i) +"\n" ;
		}
		
		gameObject.guiText.text = scores;
	
	}
	
	
	

}
