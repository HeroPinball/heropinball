using UnityEngine;
using System.Collections;
using System;

public class EnemyControl : MonoBehaviour

{


	[HideInInspector]
	public bool facingRight = true;	
	public static int initWaitTime = 150;
	public int waitTime = initWaitTime;
	public int jumpForce = 200;

	public Transform groundCheck;
	public Transform groundCheck2;
	private Boolean grounded;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		grounded = Physics2D.Linecast(groundCheck.position, groundCheck2.position, 1 << LayerMask.NameToLayer("Ground"));   

		waitTime--;

		if (waitTime == 0) 
		{

			if (facingRight &&
				GameObject.FindWithTag("Player").transform.position.x < transform.position.x)
				flip ();
			if (!facingRight &&
			    GameObject.FindWithTag("Player").transform.position.x > transform.position.x)
				flip ();

			if (facingRight && grounded)
				rigidbody2D.AddForce(new Vector2(jumpForce,jumpForce)); 
			if (!facingRight && grounded)
				rigidbody2D.AddForce(new Vector2(jumpForce * -1,jumpForce)); 

			waitTime = initWaitTime;
		}

	
	}

	Boolean onGround()
	{
		return true;
	}

	void flip ()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}


	void OnCollisionEnter2D(Collision2D c)
	{

		if (c.gameObject.CompareTag ("Sword"))
		{
				Destroy (gameObject);
				GameObject.FindGameObjectWithTag("Spawner").SendMessage("enemyKilled");
		}
	}
}
