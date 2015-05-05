using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static int Score = 0;

	public Text ScoreText;
	public GameObject PauseButton;
	public GameObject PlayButton;
	public GameObject PauseText;
	public GameObject ObstaclePrefab;
	GameObject[] ObstacleArray = new GameObject[10];

	// Use this for initialization
	void Start() {

		Score = 0;
		Time.timeScale = 0f;

		for (int i = 0; i < ObstacleArray.Length; i++) {
			ObstacleArray[i] = Instantiate(ObstaclePrefab);
			ObstacleArray[i].SetActive(false);
		}

		StartCoroutine(RePositionNewObstacleRoutine());
	}

	// Update is called once per frame
	void Update() {

	}

	IEnumerator RePositionNewObstacleRoutine() {

		while (enabled) {
			yield return new WaitForSeconds(Random.Range(.5f, 2.5f));

			foreach (GameObject obstacle in ObstacleArray) {
				if (!obstacle.activeSelf) {
					obstacle.transform.position = new Vector2(20, 0);
					obstacle.SetActive(true);
					break;
				}
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

	public void UpdateScore() {

		if (ScoreText == null) {
			Debug.Log("ScoreText is null");
		} else if (ScoreText.GetComponent<Text>() == null) {
			Debug.Log("Text component");
		} else if (Score == null) {
			Debug.Log("Score is null??? What???");
		} else {
			Debug.Log("Nothing is null...");
			ScoreText.text = string.Format("Score: {0}", Score);
		}
	}
}
