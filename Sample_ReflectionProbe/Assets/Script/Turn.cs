using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour {

	Vector3 deg;
	void Start () {
		deg = gameObject.transform.eulerAngles;

	}

	// Update is called once per frame
	void Update () {
		deg.y += 0.2f;
		if (deg.y > 360f) deg.y = 0f;
		gameObject.transform.rotation = Quaternion.Euler(deg);
	}
}
