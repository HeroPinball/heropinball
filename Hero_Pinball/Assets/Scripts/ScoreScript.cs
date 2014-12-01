using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	


	public int score;
	public int level;
	public int lives;
	public bool gameOver;
	private static int levelBonusMax = 1000;
	private int levelBonus = levelBonusMax;
	private GameObject bonusT;
	private int timer;
	
	//private CoinScript cScript;
	
	// Use this for initialization
	void Start () {
		
		timer = 0;

		score = 0;
		level = 0;
		lives = 3;
		
		levelBonus = levelBonusMax;
		
		gameOver = false;
		
		bonusT = GameObject.Find("LevelBonusTracker");
		GameObject[] s = GameObject.FindGameObjectsWithTag("Scorekeeper");

		DontDestroyOnLoad(s[0]);
			

			
		for (int i = 1 ; i < s.Length; i ++)
			Destroy(s[i]);
			

		guiText.text = "";
		bonusT.guiText.text ="";

	}
	
	void FixedUpdate()
	{
		timer--;
		if (level != 0 && gameOver == false){
			guiText.text = "Score: " + score;
			bonusT.guiText.text = "Level Bonus:" + levelBonus;
		}
		if (levelBonus > 0 && timer % 3 == 0)
			levelBonus--;
			
	}
	
	void coin(){ score += 250;}
	void enemy(){ score += 100;}
	void boss(){ score += 200;}
	
	void setGameOver()
	{
		gameOver = true;			
		guiText.text = "";
		bonusT.guiText.text ="";
	}
	

	void NextLevel()
	{ 
		level++;
		
		if (level > 1){
		score += levelBonus;
		levelBonus = levelBonusMax;
		}
		
		if (level % 3 == 1)
			Application.LoadLevel("FireLevel");
		else if (level % 3 == 2)
			Application.LoadLevel("ThunderLevel");
		else if (level % 3 == 0)
			Application.LoadLevel("IceLevel");
	}
	
	

	
	
	
}
