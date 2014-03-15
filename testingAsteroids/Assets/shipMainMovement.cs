using UnityEngine;
using System.Collections;
using System.Text;

public class shipMainMovement : MonoBehaviour {

	public float speed = 12f;
	public float firerate = 0.5f;
	public GameObject mainshipwhite;
	public GameObject lazer;
	public Transform playerTransform;

	[HideInInspector]
	public float nextshot = 0f;



	// Use this for initialization
	void Start () {
		mainshipwhite = GameObject.Find("Player");
		playerTransform = mainshipwhite.transform;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector2.right * speed * Time.deltaTime * (-1));
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector2.up * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector2.up * speed * Time.deltaTime * (-1));
		}
		//print(Time.time);

		if (Input.GetAxis("fireLaser") == 1){
			if(Time.time >= nextshot){
				Instantiate(lazer, new Vector3(playerTransform.position.x, playerTransform.position.y + 1, 0), Quaternion.identity);
				nextshot = Time.time + firerate;
			}
		}
	}
}
