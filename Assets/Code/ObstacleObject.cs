using UnityEngine;
using System.Collections;

public class ObstacleObject : MonoBehaviour {

	public float Speed;
	Vector2 Destination = new Vector2(-20, 0);

	// Use this for initialization
	void Start() {

		Vector2 newPosition = transform.position;
		newPosition.y = Random.Range(-5.5f, 0f);
		transform.position = newPosition;
		Destination.y = transform.position.y;
	}

	// Update is called once per frame
	void Update() {

		transform.position = Vector2.MoveTowards(
			transform.position,
			Destination,
			Speed * Time.deltaTime);

		if ((Vector2)transform.position == Destination) {
			gameObject.SetActive(false);
		}
	}
}
