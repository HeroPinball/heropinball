using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	public GameObject player;

	public LeroyControl script;
	private float x;
	private float y;
	public float w;
	private float h;
	// Use this for initialization
	void Start () {
	
		player = GameObject.FindGameObjectWithTag("Player");
		w = 300;
		x = guiTexture.pixelInset.x;
		y = guiTexture.pixelInset.y;
		h = guiTexture.pixelInset.height;
		script = player.GetComponent<LeroyControl>();

	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (player != null)
		{
			guiTexture.pixelInset = new Rect(x,y, 0,h);
			//Super crappy hacky way of getting desired effect
			//Set rightBorder of GUItexture to a large negative number to repeat
			//The health block the desired number of times
			guiTexture.border = new RectOffset(0, (script.health * -36) -4,0,0);
		}
	
	}
}
