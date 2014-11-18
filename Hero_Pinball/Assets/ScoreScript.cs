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


		//DontDestroyOnLoad(gameObject);
	}
	
	void FixedUpdate()
	{

		guiText.text = "Score: " + score;
	}
	
	void coin(){ score += 250;}
	void enemy(){ score += 100;}
	void boss(){ score += 200;}
	
	
	
}
