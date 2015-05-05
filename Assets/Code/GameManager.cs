using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

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
}
