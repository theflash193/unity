using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gonfle : MonoBehaviour {
	public float upScale;
	public float downScale;
	public float maximumScale;
	private bool game;
	// Use this for initialization
	void Start () {
		game = true;
	}
	
	// Update is called once per frame
	void endGame() {
		int i = (int)Time.realtimeSinceStartup;
		Debug.Log ("Balloon life time: " + i + "s");
	}

	void Update () {
		if (game) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				Vector3 old = gameObject.transform.localScale;
				old.x += upScale;
				old.y += upScale;
				gameObject.transform.localScale = old;
				if (old.x > maximumScale) {
					Destroy (gameObject);
					game = false;
					endGame();
				}
			} else {
				Vector3 old = gameObject.transform.localScale;
				old.x -= downScale;
				old.y -= downScale;
				if (old.x <= 0) {
					old.x = 0.1f;
					old.y = 0.1f;
					game = false;
					gameObject.transform.localScale = old;
					endGame();
				} else {
					gameObject.transform.localScale = old;
				}
			}
		}
	}
}
