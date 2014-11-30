using UnityEngine;
using System.Collections;

public class SocketScript : MonoBehaviour {

	public Animator animator;
	private int index;
	private GameObject[] sockets;
	// Use this for initialization
	void Awake () 
	{
	
		animator.SetBool("Active", false);
		sockets = GameObject.FindGameObjectsWithTag("Socket");
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void setActive()
	{
		
		foreach(GameObject socket in sockets )
		{
			if (socket != null)
				socket.SendMessage("deactivate");
		}
		
		animator.SetBool("Active", true);
	}
	
	void deactivate()
	{
		animator.SetBool("Active", false);
	}
	
}
