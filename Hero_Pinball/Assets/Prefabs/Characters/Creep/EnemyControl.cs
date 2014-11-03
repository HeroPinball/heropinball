using UnityEngine;
using System.Collections;
using System;

public class EnemyControl : MonoBehaviour

{
	private int health = 1;

	public Transform follow;

	[HideInInspector]
	public bool facingRight = true;	

	public float moveForce = 365f;			// Amount of force added to move the player left and right.
	public float maxSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		float h = rigidbody2D.velocity.x;

		if( rigidbody2D.velocity.x < maxSpeed && follow.position.x -transform.position.x > 0)
			// ... add a force to the player.
			rigidbody2D.AddForce(Vector2.right * moveForce);

		else if( rigidbody2D.velocity.x < maxSpeed && follow.position.x -transform.position.x < 0)
			// ... add a force to the player.
			rigidbody2D.AddForce(Vector2.right * -moveForce);
		
		// If the player's horizontal velocity is greater than the maxSpeed...
		if(Mathf.Abs(rigidbody2D.velocity.x) > maxSpeed)
			// ... set the player's velocity to the maxSpeed in the x axis.
			rigidbody2D.velocity = new Vector2(Mathf.Sign(rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);
		
		// If the input is moving the player right and the player is facing left...
		if(h > 0 && !facingRight)
			// ... flip the player.
			Flip();
		// Otherwise if the input is moving the player left and the player is facing right...
		else if(h < 0 && facingRight)
			// ... flip the player.
			Flip();
	
	}

	void Flip ()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void takeDamage()
	{

	}

	void takeDamage(int damage)
	{
		health -= damage;
	}

	void OnCollisionEnter2D(Collision2D c)
	{

		Debug.Log ("Coolide");
		Destroy(this);
	}
}
