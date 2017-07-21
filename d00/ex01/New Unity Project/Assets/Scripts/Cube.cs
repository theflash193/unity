using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
	float speed;
	float timer = 0;
	float lifetime = 80;
	public string key;
	int type;
	Vector2 posLine;
	// Use this for initialization
	void Start () {
		speed = Random.Range(0.09f, 0.23f);

		switch (key) {
		case "s":
			type = 1;
			break;
		case "a":
			type = 2;
			break;
		case "d":
			type = 3;
			break;
		default: 
			break;
		}
		posLine = new Vector2 (0, -3);
	}

	// Update is called once per frame
	void Update () {
		if (timer >= lifetime) {
			timer = 0;
			GameObject.Destroy (gameObject);
		} else {
			gameObject.transform.Translate (new Vector3 (0, -1, 0) * speed);
			if (type == 1 && Input.GetButtonDown ("S"))
				ShowDistanceMessage ();
			if (type == 2 && Input.GetButtonDown("A"))
				ShowDistanceMessage ();
			if (type == 3 && Input.GetButtonDown("D"))
				ShowDistanceMessage ();
		}
		timer += 1;

	}

	void ShowDistanceMessage() {
		float distance = Vector2.Distance(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), posLine);
		Debug.Log ("Precision " + distance);
	}
}
