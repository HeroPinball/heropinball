using UnityEngine;
using System.Collections;

public class PickupSpawner : MonoBehaviour {

	// Use this for initialization
	public GameObject coin;
	public GameObject heart;
	
	
	private bool isPickup;
	
	private GameObject[] points;
	private Vector3[] positions;
	private System.Random r;
	
		void Start ()
		{
			points = GameObject.FindGameObjectsWithTag("PickupPoint");
			positions = new Vector3[points.Length];
			for (int i = 0 ; i < points.Length ; i++ )
				positions[i] = points[i].transform.position;
			isPickup = false;
		r = new System.Random ();
		}
	

	
	// Update is called once per frame
	void FixedUpdate ()
	{
	
	if (!isPickup)
	{
		int spawnRoll = r.Next(0,100);

		if (spawnRoll > 98)
		{
			int typeRoll = r.Next(0,100);
			int posRoll = r.Next(0,positions.Length);
			
			if(typeRoll < 50)
					Instantiate (coin, positions[posRoll], transform.rotation);
			else 
					Instantiate (heart, positions[posRoll], transform.rotation);
			isPickup = true;

		}
		
	}
	}
	
	void pickedUp()
	{ isPickup = false;}
	
	
}
