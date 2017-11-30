using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {
private float time = 0.0f;
private float timeScore;
private Quaternion rotation = Quaternion.identity;
public float timeStep = 0.01f;
public GameObject boot;
public GameObject shadow;

	void Start(){
		rotation.eulerAngles = new Vector3(-90,-180,0);
	}
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		timeScore += Time.deltaTime;
		Debug.Log(Mathf.Round(timeScore));

		if (time>=1){
			var position = new Vector3(Random.Range(-1, 2), 2, 5);
			var positionShadow = new Vector3(position.x, 0, 5);
   			Instantiate(boot, position, rotation);
			Instantiate(shadow, positionShadow, rotation);
			time=0;
		}
	}
}
