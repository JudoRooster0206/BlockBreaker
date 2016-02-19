using UnityEngine;
using System.Collections;
public class Paddle : MonoBehaviour {

	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//A variable to manipulate the paddles positions
		Vector3 paddlePos=new Vector3(6f,this.transform.position.y,0f);
		//A variable to get the mouse's positions
		float MousePos=Input.mousePosition.x/Screen.width*16;
		//A restriction to prevent the paddle from leaving the screen.
		//It asks for the Mathf.Clamp function, determines what value will be clamped and sets minimum and maximum values.
		paddlePos.x=Mathf.Clamp(MousePos,0.5f,15.5f); 
		//This sets the actual paddle in the game to paddlePos.
		//this.transform.position is referring to the sprite paddles current position in the game since the script is a component for the sprite
		this.transform.position=paddlePos;

	}
}
