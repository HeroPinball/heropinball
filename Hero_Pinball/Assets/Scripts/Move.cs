using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour 
{

	private bool facingLeft = true;
	private bool canJump = true;
	public float torque = 1;
	public int jumpStrength = 50;
	public Animator animator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetMouseButton (0)) {
			animator.Play("SwordSwing");
				}

		if (Input.GetAxis ("Horizontal") > 0 && rigidbody2D.velocity.x < 10) 
		{
			if (facingLeft)
				Flip();
			rigidbody2D.AddForce (Vector2.right * 25);
			//rigidbody2D.AddTorque(-torque);
			rigidbody2D.angularDrag = 8;
		}
		
		else if (Input.GetAxis ("Horizontal") < 0 && rigidbody2D.velocity.x > -10) 
		{
			if (!facingLeft)
				Flip();

			rigidbody2D.AddForce (Vector2.right * -25);
			//rigidbody2D.AddTorque(torque);
			rigidbody2D.angularDrag = 8;
		}

		else
		{
			rigidbody2D.angularDrag = 1;
		}

		//jump
		if (Input.GetAxis ("Vertical") > 0 && canJump) 
		{

			rigidbody2D.AddForce (Vector2.up * jumpStrength);
			canJump = false;
		}

		//If goes off bottom of screen, return to top
		if (transform.position.y < -20) {
						transform.position = new Vector3 (0, 11, 0);
			rigidbody2D.AddForce (Vector2.up * 1000);//Counteract gravity
				}

		//rotate upright
		//if (rigidbody2D.angularVelocity > 0) 
		{
			//rigidbody2D.angularVelocity = 0;
		}
	}

	void Flip()
	{
		transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
		facingLeft = !facingLeft;
	}

	void OnCollisionEnter()
	{
		Debug.Log ("collide");
		canJump = true;
	}
}
