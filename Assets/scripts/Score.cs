using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
	public static int score = 0;
	public CanvasGroup canvasGroup;
	// Use this for initialization
	void Start () {
		score =0;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<UnityEngine.UI.Text> ().text = score.ToString ();

	}
	public void showStartUI()
	{
		canvasGroup.alpha = 1;
	}
	public void hideStartUI()
	{
		canvasGroup.alpha = 0;
	}
}
