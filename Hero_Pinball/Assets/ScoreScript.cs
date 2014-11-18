using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	
	private GameObject sword;

	//private GameObject coin;
	
	private SwordScript script;

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
		guiText.text = "Score: " + (script.score);
	}
	
}
