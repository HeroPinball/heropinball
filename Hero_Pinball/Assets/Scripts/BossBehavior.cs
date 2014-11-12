using UnityEngine;
using System.Collections;
using System;

public class BossBehavior : MonoBehaviour
{
	
	public int bossHealth;
	public float totalTime;
	public float eyeTimer;
	public Vector3 socket1 = new Vector3 (24, 12, -1);
	public Vector3 socket2 = new Vector3 (30, 14, -1);
	public Vector3 socket3 = new Vector3 (36, 12, -1);
	Vector3[] sockets = new Vector3[3];
	void Start ()
	{
		sockets [0] = socket1;
		sockets [1] = socket2;
		sockets [2] = socket3;
	}
	// Update is called once per frame
	void Update ()
	{ 
		eyeTimer -= Time.deltaTime;
		if (eyeTimer < 0) {
			System.Random socGen = new System.Random ();
			Vector3 mynum = sockets [socGen.Next (0, sockets.Length)];
			transform.position = mynum; 
			eyeTimer = totalTime;
		}
	}
	void damage () {
		//check for sword collision
	}
}