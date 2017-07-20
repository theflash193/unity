using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chute : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (new Vector3(0, -1, 0) * Time.deltaTime);
		gameObject.transform.Translate(new Vector3(0, -1, 0) * 0.1f);
		Debug.Log("42");
	}
}
