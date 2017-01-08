using System.Collections;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	float accel = 100.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().AddForce (transform.right * Input.GetAxisRaw ("Horizontal") * accel, ForceMode.Impulse);
	}
}
