using System.Collections;
using UnityEngine;

public class BallScript : MonoBehaviour {
	float speed = 15.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp ("Jump") && GetComponent<Rigidbody> ().velocity == new Vector3 (0, 0, 0)) {
			GetComponent<Rigidbody> ().AddForce ((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
		}
	}

	void OnCollisionEnter () {
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		rigidbody.velocity = rigidbody.velocity.normalized * 15;
	}
}
