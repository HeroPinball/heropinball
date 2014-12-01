using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {


	private GameObject pickupSpawner;
	private GameObject scorekeeper;
	
	// Use this for initialization
	void Awake ()
	 {
		pickupSpawner = GameObject.FindGameObjectWithTag("PickupSpawner");
		scorekeeper = GameObject.FindGameObjectWithTag("Scorekeeper");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
	
	void OnTriggerEnter2D(Collider2D p)
	{
		
		if (p.gameObject.CompareTag ("Player"))
		{
			scorekeeper.SendMessage("coin");
			pickupSpawner.SendMessage("pickedUp");
			Destroy(gameObject);
		}
		
	}
	
	
	
}
