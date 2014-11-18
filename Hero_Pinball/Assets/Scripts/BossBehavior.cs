using UnityEngine;
using System.Collections;
using System;

public class BossBehavior : MonoBehaviour
{
	public static int bossHealthMax = 3;
	public int bossHealth = bossHealthMax;
	public float totalTime;
	public static float eyeWait = 200;
	public float eyeTimer = eyeWait;
	
	GameObject[] sockets;
	Vector3[] positions;
	
	void Start ()
	{
		sockets = GameObject.FindGameObjectsWithTag("Socket");
		positions = new Vector3[sockets.Length];
		for (int i = 0 ; i < sockets.Length ; i++ )
			positions[i] = sockets[i].transform.position;
		move();
		
	}
	// Update is called once per frame
	void FixedUpdate ()
	{ 
		eyeTimer--;
		if (eyeTimer ==0)
		{
			eyeTimer = eyeWait;
			move ();
		}
	}
	void damage () 
	{
		bossHealth--;
		move ();
		if (bossHealth <= 0 )
			Destroy(gameObject);
			
		
	}
	
	void move()
	{
		System.Random socGen = new System.Random ();
		int random = socGen.Next (0, sockets.Length);
		Vector3 newPos = positions[random];
		transform.position = newPos ;	
	}
	
}