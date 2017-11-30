using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControls : MonoBehaviour {

void Update(){
	if(Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S)){
				transform.Translate(Vector3.back * Time.deltaTime, Space.World);
	}
	if(Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.W)){
				transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
	}
	if(Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D)){
				transform.Translate(Vector3.right * Time.deltaTime, Space.World);
	}
	if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A)){
				transform.Translate(Vector3.left * Time.deltaTime, Space.World);
	}
}

}