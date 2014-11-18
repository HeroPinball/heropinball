using UnityEngine;
using System.Collections;

public class SwordScript : MonoBehaviour {

	//public int score = 0;
	private bool attacking;
	private GameObject scorekeeper;
	// Use this for initialization
	void Start () {

		attacking = false;
		scorekeeper = GameObject.FindGameObjectWithTag("Scorekeeper");
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	}

	void OnTriggerEnter2D(Collider2D c)
	{

		if (c.gameObject.CompareTag ("Enemy") && attacking )
		{
	
			c.gameObject.SendMessage("kill");
			scorekeeper.SendMessage("enemy");
		}
		
		if (c.gameObject.CompareTag ("Boss") && attacking )
		{
			
			c.gameObject.SendMessage("damage");
			scorekeeper.SendMessage("boss");
		}

	}

	void isAttacking(){

		attacking = true;
		}
	void notAttacking(){

		attacking = false;
	}



}
