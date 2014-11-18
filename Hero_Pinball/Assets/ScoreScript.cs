using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	
	private GameObject sword;

	//private GameObject coin;
	
	private SwordScript script;

	public int score;
	//private CoinScript cScript;
	
	// Use this for initialization
	void Start () {
		
		sword = GameObject.FindGameObjectWithTag("Sword");
		//coin = GameObject.FindGameObjectWithTag("Coin");
		script = sword.GetComponent<SwordScript>();
		//cScript = coin.GetComponent<CoinScript>();
	}
	
	void FixedUpdate()
	{
		guiText.text = "Score: " + (script.score + score);
	}
	
	void coin(){ score += 250;}
	
	
	
	
}
