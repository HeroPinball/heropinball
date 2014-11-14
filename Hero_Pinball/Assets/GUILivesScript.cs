using UnityEngine;
using System.Collections;

public class GUILivesScript : MonoBehaviour {

	public GameObject player;
	
	public LeroyControl script;

	// Use this for initialization
	void Start () {
		
		player = GameObject.FindGameObjectWithTag("Player");
		script = player.GetComponent<LeroyControl>();
		
	}

	void FixedUpdate()
	{
		guiText.text = "Lives: " + script.lives;
	}

}
