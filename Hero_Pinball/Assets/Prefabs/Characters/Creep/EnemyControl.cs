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
	public int lifespan = 3000;

	public Transform groundCheck;
	public Transform groundCheck2;
	private Boolean grounded;

	public Animator animator;

	// Use this for initialization
	void Start () 
	{
		rigidbody2D.AddForce (new Vector2 (UnityEngine.Random.Range (-300, 300), UnityEngine.Random.Range (-300, 300)));
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("OneWayPlatforms")) ||Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")) ;   

		waitTime--;
		lifespan--;

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

		if (lifespan < 0)
						kill ();
	
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

		if (c.gameObject.CompareTag ("Sword") )
		{
			kill();
		}

		if (c.gameObject.CompareTag ("killBox"))
		{
			kill();
		}
	}

	void kill()
	{
		Destroy (gameObject, 0.25f);
		animator.SetTrigger("Dead");
		GameObject.FindGameObjectWithTag("Spawner").SendMessage("enemyKilled");
	}
		
}
