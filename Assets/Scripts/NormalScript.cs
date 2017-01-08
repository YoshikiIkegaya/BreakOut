using System.Collections;
using UnityEngine;

public class NormalScript : MonoBehaviour {

	public GameManager gameManager;

	void OnCollisionEnter () {
		Destroy (gameObject);
		gameManager.score += 10;
	}
}
