using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject ScoreText;
	public GameObject PauseButton;
	public GameObject PlayButton;
	public GameObject PauseText;
	public GameObject ObstaclePrefab;
	GameObject[] ObstacleArray = new GameObject[10];

	// Use this for initialization
	void Start() {

		for (int i = ObstacleArray.Length; i < ObstacleArray.Length; i++) {
			ObstacleArray[i] = Instantiate(ObstaclePrefab);
		}

		StartCoroutine(RePositionNewObstacleRoutine());
	}

	// Update is called once per frame
	void Update() {

	}

	IEnumerator RePositionNewObstacleRoutine() {

		yield return new WaitForSeconds(Random.Range(0.5f, 2f));

		foreach (GameObject obstacle in ObstacleArray) {
			if (!obstacle.activeSelf) {
				obstacle.transform.position = new Vector2(20, 0);
				obstacle.SetActive(true);
			}
		}
	}

	public void PauseGame() {

		PauseButton.GetComponent<Image>().enabled = false;
		PlayButton.GetComponent<Image>().enabled = true;
		PauseText.GetComponent<Text>().enabled = true;
		Time.timeScale = 0f;
	}

	public void ResumeGame() {

		PlayButton.GetComponent<Image>().enabled = false;
		PauseButton.GetComponent<Image>().enabled = true;
		PauseText.GetComponent<Text>().enabled = false;
		Time.timeScale = 1f;
	}
}
