using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit=0;
	public LevelMan level;
	// Use this for initialization
	void Start () {
		timesHit=0;
	
	}
	void OnCollisionEnter2D(Collision2D Collar)
	{
		timesHit+=1;
		print (timesHit);
	}
	
	// Update is called once per frame
	void Update () {
		if(timesHit==maxHits)
			level.LoadLevel("Win");
	
	}
}
