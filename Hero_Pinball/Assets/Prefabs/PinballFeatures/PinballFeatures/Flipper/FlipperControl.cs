using UnityEngine;
using System.Collections;

public class FlipperControl : MonoBehaviour {

	public int force = 2000;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D()
	{

		rigidbody2D.AddForce (Vector2.up*force);

	}
}
