﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	private float speed = -0.2f;
	private float deadLine = -10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (this.speed, 0, 0);

		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}
	}
		// なにかにぶつかったときの効果音再生
	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag"){
			GetComponent<AudioSource> ().Play();
		}
	}
}
