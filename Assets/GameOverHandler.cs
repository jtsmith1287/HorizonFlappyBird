using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverHandler : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D entity) {

		if (entity.tag == "Player") {
			Time.timeScale = 0;
			GameObject.Find("GameOverText").GetComponent<Text>().enabled = true;
			StartCoroutine(ResetLevel());

		}
	}

	IEnumerator ResetLevel() {

		float time = Time.realtimeSinceStartup + 1.5f;

		while (Time.realtimeSinceStartup < time)
			yield return null;

		Application.LoadLevel("Level1");
	}
}
