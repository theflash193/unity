using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	// un objet du type que l'on souhait faire spawn
	// Use this for initialization
	public int type;
	public GameObject a;
	public GameObject s;
	public GameObject d;

	void Start () {
		Vector3 old = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, 0);
		switch (type) {
		case 1:
			GameObject.Instantiate (a, old, Quaternion.identity);
			break ;
		case 2:
			GameObject.Instantiate (s, old, Quaternion.identity);
			break ;
		case 3:
			GameObject.Instantiate (d, old, Quaternion.identity);
			break;
		default :
			break;
		}
		Debug.Log (gameObject.transform.localPosition);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
