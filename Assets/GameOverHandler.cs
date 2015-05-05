using UnityEngine;
using System.Collections;

public class GameOverHandler : MonoBehaviour {

	void OnTriggerEnter(Collider entity) {

		if (entity.tag == "Player") {
			Time.timeScale = 0;
			Application.LoadLevel("Level1");
		}
	}
}
