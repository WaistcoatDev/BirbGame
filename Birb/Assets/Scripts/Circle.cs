using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * 1.0000001f);
	}
}
