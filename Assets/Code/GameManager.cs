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
	}

	// Update is called once per frame
	void Update() {

	}
}
