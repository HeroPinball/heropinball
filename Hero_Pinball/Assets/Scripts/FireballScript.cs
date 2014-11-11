using UnityEngine;
using System.Collections;

public class FireballScript : MonoBehaviour
{

		public Transform fireball;
		public float numFireballs;
		public float maxFireballs = 3;
		public static float fireSpawn = 10;
		public float firetimer;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void FixedUpdate ()
		{
				firetimer -= Time.deltaTime;
				if (firetimer < 0 && firetimer > -0.1 && numFireballs < 3) {
						Instantiate (fireball);
						firetimer = fireSpawn;
						numFireballs++;
						print ("You're in the loop!");
				} else {
						print ("Not in the loop.");
				}
		}
}       