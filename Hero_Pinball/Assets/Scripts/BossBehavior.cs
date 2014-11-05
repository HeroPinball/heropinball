using UnityEngine;
using System.Collections;
using System;

public class BossBehavior : MonoBehaviour
{
	
		public int bossHealth;
		public float totalTime;
		public float eyeTimer;
		public Vector2 socket1 = new Vector2 (24, 12);
		public Vector2 socket2 = new Vector2 (30, 14);
		public Vector2 socket3 = new Vector2 (36, 12);
		Vector2[] sockets = new Vector2[3];

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
						Vector2 mynum = sockets [socGen.Next (0, sockets.Length)];
						transform.position = mynum; 
						eyeTimer = totalTime;
				}
		}
}
