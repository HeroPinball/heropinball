using UnityEngine;
using System.Collections;

public class FireballScript : MonoBehaviour
{
	public float numFireballs;
	public float maxFireballs = 3;
	public static float fireSpawn = 10;
	public float firetimer;
	public Transform target;
	public float speed;
	public GameObject fireball = Instantiate(Resources.Load("eleBall", typeof(GameObject))) as GameObject;
	// Use this for initialization
	void Start ()
	{
//		target = mytarget.transform.position;


	}

	void Update() {
	//	float step = speed * 2;
		//transform.position = Vector3.MoveTowards (transform.position, leroy.position, step);
		}
	// Update is called once per frame
	void FixedUpdate ()
	{
//float step = speed * Time.deltaTime;
//		transform.position = Vector3.MoveTowards (transform.position, target.position, step);

		firetimer -= Time.deltaTime;
		if (firetimer < 0 && numFireballs < 3) {
			Instantiate (fireball);
			firetimer = fireSpawn;
			numFireballs++;
			print ("You're in the loop!");
		} else {
			print ("Not in the loop.");
		}

	}
}       