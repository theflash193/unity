using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {
	float spawnTime = 60f;
	float timer = 0;
	int note;
	public GameObject a;
	public GameObject s;
	public GameObject d;

	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (timer >= spawnTime) {
			timer = 0;
			note = Random.Range (1, 4);
			Debug.Log (note);
			if (note == 1) {
				Instantiate (a, new Vector3 (-2.22f, 3, 0), Quaternion.identity);
			} else if (note == 2) {
				Instantiate (s, new Vector3 (0, 3, 0), Quaternion.identity);
			} else {
				Instantiate (d, new Vector3 (2.22f, 3, 0), Quaternion.identity);
			}
		}
		timer += 1;
	}
}
