using UnityEngine;
using System.Collections;

public class reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionrEnter2D()
	{
		Debug.Log ("hitResetter");
		//other.transform.position = (new Vector3 (0, 0, 0));
	}
}
