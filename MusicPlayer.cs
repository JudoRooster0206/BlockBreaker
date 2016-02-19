using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	// Use this for initialization
	static MusicPlayer music=null;

	void Awake(){
		Debug.Log("Music player Awake " + GetInstanceID());
		if(music!=null){
			Destroy(gameObject);
			print ("Wild Flower clone destoryed!");
		} else{
			music=this;
			GameObject.DontDestroyOnLoad(music);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
