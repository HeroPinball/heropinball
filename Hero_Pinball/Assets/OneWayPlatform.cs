using UnityEngine;
using System.Collections;

public class OneWayPlatform : MonoBehaviour {

	public GameObject player; 
	// Use this for initialization
	void Start () {
	
		player = GameObject.FindGameObjectWithTag("Player");
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (player.rigidbody2D.velocity.y > 0)
			Physics2D.IgnoreLayerCollision (10,9, true);
		else
			Physics2D.IgnoreLayerCollision (10,9, false);
	}
	
	void OnCollisionEnter2D(Collision2D c)
	{

	}
	
}
