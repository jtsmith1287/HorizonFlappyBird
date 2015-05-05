using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject ObstaclePrefab;
	GameObject[] ObstacleArray = new GameObject[10];

	// Use this for initialization
	void Start() {
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
}
