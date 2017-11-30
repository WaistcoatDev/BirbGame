using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootMove : MonoBehaviour {
private bool bootUp = false;
private bool schwoop = false; //Triggers the boot to float out of frame
public GameObject collisionBox;

	// Update is called once per frame
	void Update () {
		if(transform.position.y>=2.5f){
			bootUp = true;
		}
		if(transform.position.y<=1.33f){
			bootUp = false;
		}
		if (bootUp==false){
			transform.Translate(Vector3.up * Time.deltaTime, Space.World);
		}
		if (bootUp==true){
			transform.Translate(Vector3.down * Time.deltaTime, Space.World);
		}	
	}
	/*This bit doesn't work, it's supposed to recognise when the Collision Detector
	Collides with the boot, but it doesn't question mark?*/

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag=="Respawn"){//the collision detector has this tag
			Debug.Log("Schwoop");
		}
	}
}