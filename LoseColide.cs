using UnityEngine;
using System.Collections;

public class LoseColide : MonoBehaviour {
	public LevelMan LevelManager;

	void OnTriggerEnter2D(Collider2D Triga){
		print ("Trigger");
		LevelManager.LoadLevel("Win");
	}
	void OnCollisionEnter2D(Collision2D Collar){
		print ("Collision");
	}
}
