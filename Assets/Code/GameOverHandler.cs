using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverHandler : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D entity) {

		if (entity.tag == "Player") {
			Time.timeScale = 0;
			Text text = GameObject.Find("GameOverText").GetComponent<Text>();
			text.text = "Game Over!\nScore: " + GameManager.Score.ToString();
			text.enabled = true;
			StartCoroutine(ResetLevel());

		}
	}

	IEnumerator ResetLevel() {

		float time = Time.realtimeSinceStartup + 3f;

		while (Time.realtimeSinceStartup < time)
			yield return null;

		Application.LoadLevel("Level1");
	}
}
