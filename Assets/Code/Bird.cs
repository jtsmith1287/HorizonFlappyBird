﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Bird : MonoBehaviour {

	public KeyCode FlapKey;
	public int FlapStrength;

	public Sprite FlapWingsUp;
	public Sprite FlapWingsDown;

	public Rigidbody2D BirdPhysics;

	// Update is called once per frame
	void Update() {

		if (Input.GetKeyDown(FlapKey)) {
			FlapWings();
		} 
		if (Input.GetKeyUp(FlapKey)) {
			ReturnWings();
		}
	}

	void FlapWings() {

		gameObject.GetComponent<SpriteRenderer>().sprite = FlapWingsUp;
		BirdPhysics.velocity = new Vector2(0, FlapStrength);
	}

	void ReturnWings() {

		gameObject.GetComponent<SpriteRenderer>().sprite = FlapWingsDown;
	}
}
