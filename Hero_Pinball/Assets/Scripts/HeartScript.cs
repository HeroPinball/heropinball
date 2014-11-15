using UnityEngine;
using System.Collections;

public class HeartScript : MonoBehaviour {
	public GameObject heart;
	public GameObject player;

	public LeroyControl script;

	public int health;
	public int maxHealth;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");

		heart = GameObject.FindGameObjectWithTag ("Healing");
		script = player.GetComponent<LeroyControl>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		health = script.health;
		maxHealth = script.maxHealthRef;
	}
	
	void OnTriggerEnter2D(Collider2D p)
	{
		
		if (p.gameObject.CompareTag ("Player") && health < maxHealth)
		{
			
			p.gameObject.SendMessage("Healed!");
			health++;
			script.health = health;
			Destroy(heart);
		}
		
	}
	

}
