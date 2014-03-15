using UnityEngine;
using System.Collections;
using System.Text;

public class wallcollide : MonoBehaviour {

	//public AudioClip grenade;

	//is trigger - delete object
	void OnTriggerEnter2D (Collider2D other) {
		if(other.tag == "wall"){
			//audio.PlayOneShot(grenade);
			Destroy (this.gameObject);
		}
	}
}
