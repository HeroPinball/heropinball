﻿using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public int maxEnemies = 5;
	private int numEnemies = 0;
	public static int spawnTime = 300;
	private int timer = spawnTime;
	public Transform creep;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per framze
	void FixedUpdate () 
	{
		timer--;


		if (numEnemies < maxEnemies && timer < 0) 
		{
			numEnemies++;
			Instantiate (creep, transform.position, transform.rotation);
			timer = spawnTime;
		}
	}

	void enemyKilled()
	{
		numEnemies--;
	}
}
