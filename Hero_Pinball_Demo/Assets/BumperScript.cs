using UnityEngine;
using System.Collections;

public class BumperScript : MonoBehaviour 
{
	float scaleFactor = 140f;
	public Animator animator;

	void OnCollisionEnter2D (Collision2D c)
	{

		animator.Play("Bump");
		float cVx = c.rigidbody.velocity.x;
		float cVy = c.rigidbody.velocity.y;
		Vector2 bumpForce = new Vector2 (-cVx* scaleFactor  , -cVy * scaleFactor);
		c.rigidbody.AddForce (bumpForce);



	}
}
