using UnityEngine;
using System.Collections;
using System;

public class LeroyControl : MonoBehaviour

{
	private int health = 3;
	private int lives = 3;

	private float maxWalkSpeed = 3.0f;
	private float maxSpeed = 3.0f;
	private int walkForce = 50;
	private int jumpForce = 500;

	private Boolean facingRight = true;
	private Boolean grounded; 
	private Boolean jump;

	public Transform groundCheck;

	private float input;

	//private float vX;
	private float vY;

	private Vector3 spawn;

	void Awake()
	{
		spawn = transform.position;
	}

	void OnCollisionEnter2D(Collision2D c)
	{

		if (c.gameObject.CompareTag ("Damaging")) 
		{
			Debug.Log ("ow");
			health--;
			if (health == 0)
			{

				lives--;
				health = 3;
				Debug.Log ("DEAD!");
				transform.position = spawn;
				if (lives == 0)
				{
					c.gameObject.tag = "Player";
					Destroy (gameObject);
				}
			}
		}

	}

	void death()
	{

	}

	void FixedUpdate ()
	{
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("OneWayPlatforms")) ||Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")) ;   

		input = Input.GetAxis("Horizontal");

		//vX = rigidbody2D.velocity.x;
		vY = rigidbody2D.velocity.y;

		maxSpeed = Mathf.Max (vY, maxWalkSpeed);



		// If the player is changing direction (h has a different sign to velocity.x) or hasn't reached maxSpeed yet...
		if(input * rigidbody2D.velocity.x < maxSpeed)
			// ... add a force to the player.
			rigidbody2D.AddForce(Vector2.right * input * walkForce);
		
		// If the player's horizontal velocity is greater than the maxSpeed...
		if(Mathf.Abs(rigidbody2D.velocity.x) > maxSpeed)
			// ... set the player's velocity to the maxSpeed in the x axis.
			rigidbody2D.velocity = new Vector2(Mathf.Sign(rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);
		
		// If the input is moving the player right and the player is facing left...
		if(input > 0 && !facingRight)
			// ... flip the player.
			flip();
		// Otherwise if the input is moving the player left and the player is facing right...
		else if(input < 0 && facingRight)
			// ... flip the player.
			flip();

		if (Input.GetButtonDown("Jump") && grounded) 
		{
				
				jump = true;
		}
		// If the player should jump...
		if(jump)
		{
			// Add a vertical force to the player.
			rigidbody2D.AddForce(new Vector2(0f, jumpForce));
			
			// Make sure the player can't jump again until the jump conditions from Update are satisfied.
			jump = false;
		}


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

}
