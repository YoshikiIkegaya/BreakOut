using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWallScript : MonoBehaviour {

	public GameManager gameManager;
	public GameObject ballPrefab;
	Vector3 placePosition = new Vector3 (0f, 0.6f, - 7f);

	void OnCollisionEnter ( Collision collision ) {
		Destroy (collision.gameObject);

		if (gameManager.life > 0) {
		
			Instantiate (
				ballPrefab,
				placePosition,
				Quaternion.identity
			);

			gameManager.life--;
		}
	}
}
