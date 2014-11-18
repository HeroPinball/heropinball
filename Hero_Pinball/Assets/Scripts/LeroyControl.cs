using UnityEngine;
using System.Collections;
using System;

public class LeroyControl : MonoBehaviour

{
	public static int maxHealth = 5;
	public int health = maxHealth;
	public static int startLives;
	public int lives = startLives;
	public int maxHealthRef;

	private float maxWalkSpeed = 3.0f;
	private float maxSpeed = 3.0f;
	private int walkForce = 50;
	private int jumpForce = 250;

	private Boolean facingRight = true;
	private Boolean grounded; 
	private Boolean jump;
	public bool attacking;
	private static int attackTime = 35;
	private int attackTimeCur = attackTime;
	public Transform groundCheck;

	private float input;

	//private float vX;
	private float vY;

	private Vector3 spawn;

	public Animator animator;
	private GameObject sword;

	void Awake()
	{
		spawn = transform.position;
		sword = GameObject.FindGameObjectWithTag("Sword");
	}

	void OnCollisionEnter2D(Collision2D c)
	{

		if (c.gameObject.CompareTag ("Damaging") && !attacking) 
		{
			Debug.Log ("ow");
			health--;
			if (health == 0)
			{

				lives--;
				health = maxHealth;
				Debug.Log ("DEAD!");
				transform.position = spawn;
				if (lives == 0)
				{
					gameOver(c.gameObject);
				}
			}
		}

		if (c.gameObject.CompareTag ("killBox")) 
		{
			lives--;
			health = maxHealth;
			Debug.Log ("DEAD!");
			transform.position = spawn;
			if (lives == 0)
			{
				gameOver(c.gameObject);
			}
		}

	}

	void gameOver(GameObject c)
	{
		c.gameObject.tag = "Player";
		Destroy (gameObject);
		Application.LoadLevel("GameOver");

	}

	void FixedUpdate ()
	{
		maxHealthRef = maxHealth;

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

		if (Input.GetButtonDown ("Fire1") && !attacking) 
		{
			animator.SetTrigger("Attack");
			attacking = true;
			sword.SendMessage("isAttacking");
		}
		if (attacking) 
		{
			attackTimeCur--;
			if (attackTimeCur == 0)
			{
				attacking = false;
				attackTimeCur = attackTime;
				sword.SendMessage("notAttacking");
			}
				
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

	int getHealth()
	{
		return health;
	}

}
