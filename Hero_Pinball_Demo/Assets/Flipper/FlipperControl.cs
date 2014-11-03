using UnityEngine;
using System.Collections;

public class FlipperControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D()
	{

		rigidbody2D.AddForce (Vector2.up*3000);

		}
}
