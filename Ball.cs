using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Paddle paddle;
	private bool has_started=false;
	private Vector3 paddleToBallVector; 
	// Use this for initialization
	void Start () {
		paddleToBallVector=this.transform.position-paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(!has_started){
			//Lock the ball to the paddle.
		this.transform.position=paddle.transform.position + paddleToBallVector;
		}
		if(Input.GetMouseButtonDown(0)){
			has_started=true;
			print ("Mouse clicked, Launching ball");
			this.rigidbody2D.velocity=new Vector2(2f,10f);
		}
	
	}
}
