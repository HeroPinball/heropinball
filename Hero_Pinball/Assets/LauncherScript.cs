using UnityEngine;
using System.Collections;

public class LauncherScript : MonoBehaviour {

	private float x;
	private float y;
	private float z;
	private float scaleShrink = 0.04f;
	private float scaleGrow = 0.4f;
	private float initScaleY;
	private int launchForce = 200;
	private bool touchingPlayer;
	// Use this for initialization
	void Start () 
	{
	
		initScaleY =  transform.localScale.y;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		x = transform.localScale.x;
		y = transform.localScale.y;
		z = transform.localScale.z;
		

		if (Input.GetAxis ("Vertical") < 0 && y > .8)
		{
			transform.localScale = new Vector3 (x,y - scaleShrink , z );
		}
		
		else if ( y < initScaleY && !(Input.GetAxis ("Vertical") < 0) )
		{
			transform.localScale = new Vector3 (x,y + scaleGrow , z );
			if (touchingPlayer)
				GameObject.FindGameObjectWithTag("Player").rigidbody2D.AddForce(new Vector2(0, launchForce));
		}
	
	}
	
	void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.CompareTag("Player"))
			touchingPlayer = true;
			
	}
	
	void OnCollisionExit2D(Collision2D c)
	{
		if (c.gameObject.CompareTag("Player"))
			touchingPlayer = false;
		
	}
	
}
