using UnityEngine;
using System.Collections;

public class launchFireball : MonoBehaviour {

	public int maxFireballs = 5;
	private int numFireballs = 0;
	public static int launchTime = 300;
	private int timer = launchTime;
	public Transform fireball;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per framze
	void FixedUpdate () 
	{
		timer--;
		
		
		if (numFireballs < maxFireballs && timer < 0) 
		{
			numFireballs++;
			Instantiate (fireball, transform.position, transform.rotation);
			timer = launchTime;
		}
	}
	
	void fbDestroyed()
	{
		numFireballs--;
	}


}
