using UnityEngine;
using System.Collections;

public class SocketScript : MonoBehaviour {

	public Animator animator;
	private int index;
	private GameObject[] sockets;
	private GameObject socket;
	// Use this for initialization
	void Awake () 
	{
	
		animator.SetBool("Active", false);
		sockets = GameObject.FindGameObjectsWithTag("Socket");


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
