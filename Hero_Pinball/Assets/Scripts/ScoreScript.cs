using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	


	public int score;
	public int level;
	public int lives;
	public bool gameOver;
	//private CoinScript cScript;
	
	// Use this for initialization
	void Start () {
		

		score = 0;
		level = 0;
		lives = 3;
		guiText.text = "";
		gameOver = false;
		GameObject[] s = GameObject.FindGameObjectsWithTag("Scorekeeper");
			DontDestroyOnLoad(s[0]);
		for (int i = 1 ; i < s.Length; i ++)
			Destroy(s[i]);
		
	}
	
	void FixedUpdate()
	{
		if (level != 0 && gameOver == false)
			guiText.text = "Score: " + score;

			
	}
	
	void coin(){ score += 250;}
	void enemy(){ score += 100;}
	void boss(){ score += 200;}
	void setGameOver()
	{
		gameOver = true;			
		guiText.text = "";
	}
		 

	void NextLevel()
	{ 
		level++;
		
		if (level % 3 == 1)
			Application.LoadLevel("FireLevel");
		else if (level % 3 == 2)
			Application.LoadLevel("ThunderLevel");
		else if (level % 3 == 0)
			Application.LoadLevel("IceLevel");
	}

	
	
	
}
