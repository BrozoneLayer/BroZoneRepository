using UnityEngine;
using System.Collections;

public class trailcontactsound : MonoBehaviour {

	public AudioClip sound;

	void OnTriggerEnter2D(Collider2D woot){
		AudioSource.PlayClipAtPoint(sound, new Vector3(0.0f,0.0f,0.0f));
	}
	
}
