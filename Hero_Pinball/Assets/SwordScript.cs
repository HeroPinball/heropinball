using UnityEngine;
using System.Collections;

public class SwordScript : MonoBehaviour {

	public int score = 0;
	private bool attacking;
	// Use this for initialization
	void Start () {

		attacking = false;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	}

	void OnTriggerEnter2D(Collider2D c)
	{

		if (c.gameObject.CompareTag ("Damaging") && attacking )
		{
	
			c.gameObject.SendMessage("kill");
			score = score + 100;
		}

	}

	void isAttacking(){

		attacking = true;
		}
	void notAttacking(){

		attacking = false;
	}



}
