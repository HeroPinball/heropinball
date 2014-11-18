using UnityEngine;
using System.Collections;

public class HeartScript : MonoBehaviour {
	

	private GameObject player;
	private LeroyControl script;
	private GameObject pickupSpawner;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		script = player.GetComponent<LeroyControl>();
		pickupSpawner = GameObject.FindGameObjectWithTag("PickupSpawner");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
	
	void OnTriggerEnter2D(Collider2D p)
	{
		
		if (p.gameObject.CompareTag ("Player"))
		{
			
			//p.gameObject.SendMessage("Healed!");
			
			script.health = script.health + 1;
			pickupSpawner.SendMessage("pickedUp");
			Destroy(gameObject);
		}
		
	}
	

}
