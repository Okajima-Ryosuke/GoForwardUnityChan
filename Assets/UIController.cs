using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

	private GameObject gameoverText;

	private GameObject runLenthText;

	private float len = 0;

	private float speed = 0.03f;

	private bool isGameOver = false;

	// Use this for initialization
	void Start () {
		this.gameoverText = GameObject.Find ("GameOver");
		this.runLenthText = GameObject.Find ("RunLength");
	}

	// Update is called once per frame
	void Update () {
			if (this.isGameOver == false){
				this.len += this.speed;

				this.runLenthText.GetComponent<Text> ().text ="Distance: " + len.ToString ("F2") + "m";
			}

		if (this.isGameOver == true) {
			if (Input.GetMouseButtonDown (0)) {
				SceneManager.LoadScene ("GameScene");
			}
		}

	}

	public void GameOver(){
		this.gameoverText.GetComponent<Text> ().text = "GameOver";
		this.isGameOver = true;
	}
}
