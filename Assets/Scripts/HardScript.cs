using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardScript : MonoBehaviour {

	public GameManager gameManager;
	int hp = 2;

	void OnCollisionEnter (){
		hp--;
		if (hp == 0) {
			Destroy (gameObject);
			gameManager.score += 20;
		}
	}
}
