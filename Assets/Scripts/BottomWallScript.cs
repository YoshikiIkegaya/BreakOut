using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomWallScript : MonoBehaviour {

	GameObject obj;
	public GameManager gameManager;
	public GameObject ballPrefab;
	Vector3 placePosition = new Vector3(0f, 0.6f, -7f);

	void OnCollisionEnter ( Collision collision ){

//		Application.LoadLevel (0);
		Destroy (collision.gameObject);

		if (gameManager.life > 0) {

			Instantiate (
				ballPrefab,
				placePosition,
				Quaternion.identity
			);

			gameManager.life--;
		}
		else if (gameManager.life == 0){
			SceneManager.LoadScene("GameOver");
		}
	}
}