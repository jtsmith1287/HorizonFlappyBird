using UnityEngine;
using System.Collections;

public class GetAPoint : MonoBehaviour {

	GameManager GM;

	void Start() {

		GM = FindObjectOfType<GameManager>();
	}

	void OnTriggerEnter2D(Collider2D collider) {

		if (collider.tag == "Player") {
			GameManager.Score++;
			GM.UpdateScore();
		}
	}
}
