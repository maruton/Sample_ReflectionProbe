using UnityEngine;
using System.Collections;

public class Move7 : MonoBehaviour {

	Vector3 pos;
	void Start() {
		pos = gameObject.transform.position;

	}

	float moveDelata = 0.1f;
	void Update() {
		if (pos.x >  7f) moveDelata = -0.1f;
		if (pos.x < -7f) moveDelata =  0.1f;
		pos.x += moveDelata;
		gameObject.transform.position = pos;
	}

}
