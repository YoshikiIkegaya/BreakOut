using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenetrateScript : MonoBehaviour {

	public GameManager gameManager;

	void  OnTriggerEnter (){
		Destroy(gameObject);
		gameManager.score += 10;
	}
}
