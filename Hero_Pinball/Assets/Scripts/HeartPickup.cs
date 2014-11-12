using UnityEngine;
using System.Collections;

public class HeartPickup : MonoBehaviour {

	public bool isTouched;
	public GameObject leroy;// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player")
			coll.gameObject.SendMessage("ApplyHealth", 1);

//		if (c.gameObject.CompareTag ("Healing")) 
//		{
//			Debug.Log ("woo!");
//			health++;
//			if (health > 3)
//			{
//				health = 3;
//				Debug.Log ("too healthy");
//			}
//		}
	}
	}
