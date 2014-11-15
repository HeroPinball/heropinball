using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {
	public int score = 0;
	public GameObject coin;
	// Use this for initialization
	void Start () {
		coin = GameObject.FindGameObjectWithTag ("Coin");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
	
	void OnTriggerEnter2D(Collider2D p)
	{
		
		if (p.gameObject.CompareTag ("Player"))
		{
			
			p.gameObject.SendMessage("Loot!");
			score = score + 250;
			Destroy(coin);
		}
		
	}
	
}
