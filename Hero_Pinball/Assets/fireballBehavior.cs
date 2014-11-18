using UnityEngine;
using System.Collections;

public class fireballBehavior : MonoBehaviour {

	private GameObject player;
	private float pPosX;
	private float pPosY;
	private float posX;
	private float posY;
	private static float speedBoost = 100;
	private int lifespan = 300;
	private GameObject fireballSpawner;
	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag("Player");
		pPosX = player.transform.position.x;
		pPosY = player.transform.position.y + 1f;
		posX = transform.position.x;
		posY = transform.position.x;
		fireballSpawner = GameObject.FindGameObjectWithTag("BossMouth");
		rigidbody2D.AddForce(new Vector2((posX - pPosX)*( -speedBoost), (posY - pPosY) * -speedBoost) );
		transform.rotation = new Quaternion((posX - pPosX)* 360,(posY - pPosY)* 360,0);
	}

	void FixedUpdate()
	{
		lifespan--;
		if (lifespan == 0)
		{
			fireballSpawner.SendMessage("fbDestroyed");
			Destroy(gameObject);
		}

	}

	
	void OnTriggerEnter2D(Collider2D p)
	{

		if (p.gameObject.CompareTag ("Platform"))
		{
			
			

			fireballSpawner.SendMessage("fbDestroyed");
			Destroy(gameObject);
		}
		
		if (p.gameObject.CompareTag ("Player"))
		{


			player.SendMessage("takeDamage");
			fireballSpawner.SendMessage("fbDestroyed");
			Destroy(gameObject);
		}

		
	}
}
