using UnityEngine;
using System.Collections;
using System.Text;

public class lazer_script : MonoBehaviour {

	public float speed = 50.0f;
	[HideInInspector]
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.AddForce (Vector2.up * speed);// * Time.deltaTime);
		//Destroy (this.gameObject);
		if(this.transform.position.y >= 70.0f){
			Destroy (this.gameObject);
		}
	}
}
