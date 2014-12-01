using UnityEngine;
using System.Collections;

public class GUILivesScript : MonoBehaviour {

	public GameObject scorekeeper;
	
	public ScoreScript script;

	// Use this for initialization
	void Start () {
		
		scorekeeper = GameObject.FindGameObjectWithTag("Scorekeeper");
		script = scorekeeper.GetComponent<ScoreScript>();
		
	}

	void FixedUpdate()
	{
		guiText.text = "Lives: " + script.lives;
	}

}
