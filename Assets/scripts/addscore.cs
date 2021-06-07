using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addscore : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	private void OnTriggerEnter2D(Collider2D collision){

			Score.score++;
			//Debug.Log (Score.score);

	}
}
