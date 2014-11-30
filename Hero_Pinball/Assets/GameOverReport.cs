using UnityEngine;
using System.Collections;

public class GameOverReport : MonoBehaviour 
{

	
	private GameObject scorekeeper;
	private bool newHighscore;
	private int[] highscores;
	// Use this for initialization
	void Start () 
	{
		newHighscore = false;
		scorekeeper = GameObject.FindGameObjectWithTag("Scorekeeper");
		ScoreScript script = scorekeeper.GetComponent<ScoreScript>();
		int score = script.score;
		gameObject.guiText.text = "You made it to level "+  script.level + " and scored " + score 
		+ " points,";
		
		GameObject hs = GameObject.Find("newHighscore");
		hs.guiText.text = "";
		
		highscores = new int[10];
		
		for (int i = 0; i <= 9; i++)
		{
			highscores[i] = PlayerPrefs.GetInt("Score"+i);
		}
		

		int replaceIndex = 0;
		
		for (int i = 0; i <= 8; i++)
		{
			if (score >= highscores[i] && score < highscores[i+1])
				{replaceIndex = i;}
		
		}	
		
		
		if (score > highscores[9])
			{replaceIndex = 9;}
		if (score < highscores[0])
			{replaceIndex = -1;}
		
		if (replaceIndex >= 0)
		{
			for (int j = 0; j < replaceIndex; j++)
				{
					PlayerPrefs.SetInt("Score"+(j), highscores[j+1]);
				}
		}
				                                           	                                         
		if (replaceIndex != -1)
			{newHighscore = true;}
	
		PlayerPrefs.SetInt("Score"+(replaceIndex), score);
		

		if (newHighscore)
			hs.guiText.text = "New Highscore! " + ((replaceIndex -10 ) * -1)+"th Place";
	
	}
}