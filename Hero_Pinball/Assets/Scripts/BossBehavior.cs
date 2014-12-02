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
	public AudioSource Death;
	public AudioSource song1;
	public AudioSource song2;
	public AudioSource song3;
	
	public Animator animator;
	
	GameObject[] sockets;
	Vector3[] positions;
	
	GameObject scorekeeper;
	
	void Start ()
	{
		sockets = GameObject.FindGameObjectsWithTag("Socket");
		//Destroy(sockets[0]);
		//Destroy(sockets[1]);
		
		positions = new Vector3[sockets.Length];
		for (int i = 0 ; i < sockets.Length ; i++ )
			positions[i] = new Vector3( sockets[i].transform.position.x , sockets[i].transform.position.y, sockets[i].transform.position.z + 2);
		move();
		scorekeeper = GameObject.FindGameObjectWithTag("Scorekeeper");
		song2.Stop();
		song2.Stop();
		
		song1.Play();
		
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
		animator.SetTrigger("Damage");
		bossHealth--;
		move ();
		
		if (bossHealth == 2)
			{
				song1.Stop();
				song2.Play();
			
			}
			
		if (bossHealth == 1)
		{
	
			song3.Play();
			
		}
		
		if (bossHealth <= 0 )
		{
			song3.Stop();
			Death.Play();
			Destroy(gameObject);
			scorekeeper.SendMessage("NextLevel");

		}
			
			
			
		
	}
	
	void move()
	{

		System.Random socGen = new System.Random ();
		int random = socGen.Next (0, sockets.Length);
		Vector3 newPos = positions[random];
		
		transform.position = newPos ;	
		sockets[random].SendMessage("setActive");
	}
	
}