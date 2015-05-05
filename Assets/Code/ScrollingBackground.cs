using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {

	[Header("Scrolling Background Data")]
	public Material BackgroundMat;
	[Range(0.01f, 0.3f)]
	public float ScrollSpeed = 0.1f;
	public Vector2 TextureOffset;

	// Update is called once per frame
	void Update() {

		TextureOffset.x += Time.deltaTime * ScrollSpeed;
		BackgroundMat.mainTextureOffset = TextureOffset;
	}
}
