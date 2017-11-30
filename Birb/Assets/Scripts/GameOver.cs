using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag=="Player"){
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			Debug.Log("Game Over");
		}
	}
}
