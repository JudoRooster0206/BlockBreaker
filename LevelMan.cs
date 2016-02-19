using UnityEngine;
using System.Collections;

public class LevelMan : MonoBehaviour {
	public void LoadLevel(string name) {
		Debug.Log("Level load requested for " + name);
		Application.LoadLevel(name);
	}
	public void QuitGame(){
		Debug.Log("Quitting game...");
		Application.Quit();
	}
	
}
